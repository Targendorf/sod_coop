using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SoDCoop.UI.Coop;

/// <summary>
/// Resolves the local LAN IP and (optionally, on demand) the external WAN
/// IP. Local lookup is synchronous and instant; WAN lookup hits api.ipify.org
/// on a background task and may fail if the user's firewall blocks it.
/// </summary>
public static class IpDiscovery
{
    /// <summary>Best-effort guess of our LAN IPv4 address.</summary>
    public static string GetLocalIp()
    {
        try
        {
            // Trick: connect a UDP socket to a public IP, ask for our local
            // endpoint. No packet is actually sent; this just resolves the
            // route table entry.
            using var sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0);
            sock.Connect("8.8.8.8", 65530);
            if (sock.LocalEndPoint is IPEndPoint ep) return ep.Address.ToString();
        }
        catch { }

        // Fallback — first non-loopback IPv4 from DNS.
        try
        {
            foreach (var addr in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork && !IPAddress.IsLoopback(addr))
                    return addr.ToString();
            }
        }
        catch { }
        return "127.0.0.1";
    }

    /// <summary>Async lookup of WAN IP via ipify.org. Returns null on failure.</summary>
    public static async Task<string> GetExternalIpAsync()
    {
        try
        {
            using var http = new HttpClient { Timeout = System.TimeSpan.FromSeconds(4) };
            var ip = (await http.GetStringAsync("https://api.ipify.org")).Trim();
            if (System.Net.IPAddress.TryParse(ip, out _)) return ip;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"IpDiscovery.GetExternalIpAsync: {ex.Message}");
        }
        return null;
    }
}
