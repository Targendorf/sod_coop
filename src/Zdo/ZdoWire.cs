using System;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Zdo;

/// <summary>
/// Hand-written binary read/write helpers for ZDO property-value payloads.
/// The Roslyn <c>[NetPacket]</c> generator handles fixed-shape struct packets
/// but ZDO payloads are variable-length per-key with a tag byte selecting
/// the value type. This file owns the tag-prefixed encoding so it stays in
/// one place.
/// </summary>
public static class ZdoWire
{
    /// <summary>Write a tagged value at <paramref name="vt"/> from <paramref name="zdo"/>.</summary>
    public static void WriteValue(NetDataWriter w, ZdoValueType vt, Zdo zdo, int key)
    {
        switch (vt)
        {
            case ZdoValueType.Int:        w.Put((byte)vt); w.Put(zdo.GetInt(key));        break;
            case ZdoValueType.Float:      w.Put((byte)vt); w.Put(zdo.GetFloat(key));      break;
            case ZdoValueType.Bool:       w.Put((byte)vt); w.Put(zdo.GetBool(key));       break;
            case ZdoValueType.Byte:       w.Put((byte)vt); w.Put(zdo.GetByte(key));       break;
            case ZdoValueType.String:     w.Put((byte)vt); w.Put(zdo.GetString(key) ?? ""); break;
            case ZdoValueType.Vector3:    {
                w.Put((byte)vt);
                var v = zdo.GetVector3(key);
                w.Put(v.x); w.Put(v.y); w.Put(v.z);
                break;
            }
            case ZdoValueType.Quaternion: {
                w.Put((byte)vt);
                var q = zdo.GetQuaternion(key);
                w.Put(q.x); w.Put(q.y); w.Put(q.z); w.Put(q.w);
                break;
            }
            case ZdoValueType.Blob:       {
                w.Put((byte)vt);
                var b = zdo.GetBlob(key) ?? Array.Empty<byte>();
                w.Put(b.Length);
                if (b.Length > 0) w.Put(b, 0, b.Length);
                break;
            }
            case ZdoValueType.ULong:      w.Put((byte)vt); w.Put(zdo.GetULong(key));      break;
            case ZdoValueType.Zdoid:      w.Put((byte)vt); zdo.GetZdoid(key).Write(w);    break;
            case ZdoValueType.Delete:     w.Put((byte)vt);                                break;
        }
    }

    /// <summary>Read a tagged value off the wire and apply it to <paramref name="target"/>
    /// at <paramref name="key"/>.</summary>
    public static void ReadValueInto(NetDataReader r, int key, Zdo target)
    {
        ZdoValueType vt = (ZdoValueType)r.GetByte();
        switch (vt)
        {
            case ZdoValueType.Int:        target.Set(key, r.GetInt());    break;
            case ZdoValueType.Float:      target.Set(key, r.GetFloat());  break;
            case ZdoValueType.Bool:       target.Set(key, r.GetBool());   break;
            case ZdoValueType.Byte:       target.Set(key, r.GetByte());   break;
            case ZdoValueType.String:     target.Set(key, r.GetString()); break;
            case ZdoValueType.Vector3:    target.Set(key, new Vector3(r.GetFloat(), r.GetFloat(), r.GetFloat()));    break;
            case ZdoValueType.Quaternion: target.Set(key, new Quaternion(r.GetFloat(), r.GetFloat(), r.GetFloat(), r.GetFloat())); break;
            case ZdoValueType.Blob:       {
                int len = r.GetInt();
                byte[] buf = new byte[len];
                // Bulk copy: the writer uses w.Put(b, 0, len), so the reader
                // must mirror it with a single BlockCopy instead of a per-byte
                // GetByte() loop. On snapshot restores with many blob keys
                // (evidence dataKeys, fingerprints) the loop was an O(len)
                // method-dispatch cost per blob — BlockCopy is a single memcpy.
                if (len > 0) Buffer.BlockCopy(r.RawData, r.Position, buf, 0, len);
                r.SkipBytes(len);
                target.Set(key, buf);
                break;
            }
            case ZdoValueType.ULong:      target.Set(key, r.GetULong()); break;
            case ZdoValueType.Zdoid:      target.Set(key, ZDOID.Read(r)); break;
            case ZdoValueType.Delete:     target.Delete(key); break;
            default:
                throw new InvalidOperationException($"ZdoWire.ReadValueInto: unknown value type tag {(byte)vt}");
        }
    }

    /// <summary>Skip a tagged value without applying. Used when the receiving
    /// peer doesn't recognise the ZDO type tag (forward-compat).</summary>
    public static void SkipValue(NetDataReader r)
    {
        ZdoValueType vt = (ZdoValueType)r.GetByte();
        switch (vt)
        {
            case ZdoValueType.Int:        r.GetInt();    break;
            case ZdoValueType.Float:      r.GetFloat();  break;
            case ZdoValueType.Bool:       r.GetBool();   break;
            case ZdoValueType.Byte:       r.GetByte();   break;
            case ZdoValueType.String:     r.GetString(); break;
            case ZdoValueType.Vector3:    r.GetFloat(); r.GetFloat(); r.GetFloat(); break;
            case ZdoValueType.Quaternion: r.GetFloat(); r.GetFloat(); r.GetFloat(); r.GetFloat(); break;
            case ZdoValueType.Blob:       {
                // Bulk skip: read length then SkipBytes, mirroring the writer's
                // bulk Put. Per-byte GetByte() loop was O(len) dispatches.
                int len = r.GetInt();
                r.SkipBytes(len);
                break;
            }
            case ZdoValueType.ULong:      r.GetULong(); break;
            case ZdoValueType.Zdoid:      ZDOID.Read(r); break;
            case ZdoValueType.Delete:     break;
        }
    }
}
