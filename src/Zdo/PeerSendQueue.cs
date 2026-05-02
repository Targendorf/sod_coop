using System;
using System.Collections.Generic;
using LiteNetLib;
using SoDCoop.Network.Steam;
using LiteNetLib.Utils;

namespace SoDCoop.Zdo;

/// <summary>
/// Application-layer outbound queue with bounded capacity and 80%
/// backpressure log. Sits between ZdoMan (and other senders) and
/// LiteNetLib's reliable channel buffer.
///
/// <para>Drop policy under backpressure: reliable packets block (queue
/// implicitly grows by allocation since LiteNetLib is non-blocking, but
/// we log loud warning); unreliable packets drop oldest-first. In practice
/// the 80% warning is the canary — at that point latency is already
/// growing.</para>
///
/// <para>Currently maintained as scaffold; <see cref="ZdoMan"/> calls
/// <see cref="NetworkManager.SendToAll"/> directly today. The queue
/// activates when bandwidth diagnostics show backpressure in real sessions.</para>
/// </summary>
public sealed class PeerSendQueue
{
    public int Capacity { get; }
    public int Count => _q.Count;

    public bool IsBackpressured => _q.Count >= (Capacity * 4 / 5);

    public event Action<int> OnBackpressure;

    private readonly Queue<(byte[] payload, DeliveryMethod ch)> _q = new();
    private bool _backpressureLogged;

    public PeerSendQueue(int capacity = 1024)
    {
        Capacity = Math.Max(16, capacity);
    }

    public bool Enqueue(byte[] payload, DeliveryMethod channel)
    {
        if (_q.Count >= Capacity)
        {
            // Drop oldest unreliable when queue full and incoming is unreliable.
            if (channel == DeliveryMethod.Unreliable || channel == DeliveryMethod.Sequenced)
            {
                int dropped = 0;
                while (_q.Count >= Capacity && dropped < 8)
                {
                    var (_, oldCh) = _q.Peek();
                    if (oldCh == DeliveryMethod.Unreliable || oldCh == DeliveryMethod.Sequenced)
                    {
                        _q.Dequeue();
                        dropped++;
                    }
                    else break;
                }
                if (_q.Count >= Capacity) return false;
            }
            else
            {
                // Reliable + queue full → grow (acceptable temporary).
                Plugin.Log.LogWarning($"[PeerSendQueue] reliable enqueue past capacity {Capacity} (count={_q.Count})");
            }
        }

        _q.Enqueue((payload, channel));

        if (IsBackpressured && !_backpressureLogged)
        {
            _backpressureLogged = true;
            try { OnBackpressure?.Invoke(_q.Count); } catch { }
            Plugin.Log.LogWarning($"[PeerSendQueue] backpressure: {_q.Count}/{Capacity} (80%)");
        }
        return true;
    }

    public void DrainTo(SteamPeer peer, int maxBudgetBytes = 16384)
    {
        if (peer == null) return;
        int sent = 0;
        while (_q.Count > 0 && sent < maxBudgetBytes)
        {
            var (payload, ch) = _q.Peek();
            if (sent + payload.Length > maxBudgetBytes && sent > 0) break;
            _q.Dequeue();
            try { peer.Send(payload, ch); } catch (Exception ex) { Plugin.Log.LogWarning($"[PeerSendQueue] send: {ex.Message}"); }
            sent += payload.Length;
        }

        if (_backpressureLogged && _q.Count < (Capacity * 3 / 5))
        {
            _backpressureLogged = false;
            Plugin.Log.LogInfo($"[PeerSendQueue] backpressure cleared: {_q.Count}/{Capacity}");
        }
    }

    public void Clear() { _q.Clear(); _backpressureLogged = false; }
}
