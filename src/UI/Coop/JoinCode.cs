using System;
using System.Text;

namespace SoDCoop.UI.Coop;

/// <summary>
/// Compact human-shareable code that bundles the host's connection info
/// and city share-code into one string the joiner can paste.
///
/// Format (pipe-separated, base64'd whole):
///   <c>cityName|seedString|version|ip|port</c>
///
/// Example raw: <c>"New Babylon|abc123|0.6.5|192.168.1.5|9050"</c>
/// Encoded:     <c>"TmV3IEJhYnlsb258YWJjMTIzfDAuNi41fDE5Mi4xNjguMS41fDkwNTA="</c>
///
/// Encoding adds line-noise resistance so people can paste from chat
/// without losing characters; decoding is permissive on whitespace.
/// </summary>
public static class JoinCode
{
    public static string Encode(string cityName, string seed, string version, string ip, int port)
    {
        try
        {
            var raw = $"{cityName ?? ""}|{seed ?? ""}|{version ?? ""}|{ip ?? "127.0.0.1"}|{port}";
            return System.Convert.ToBase64String(Encoding.UTF8.GetBytes(raw));
        }
        catch
        {
            return "";
        }
    }

    public static bool TryDecode(string code, out string cityName, out string seed,
                                 out string version, out string ip, out int port)
    {
        cityName = seed = version = ip = "";
        port = 0;
        if (string.IsNullOrWhiteSpace(code)) return false;

        try
        {
            var trimmed = code.Trim().Replace("\r", "").Replace("\n", "").Replace(" ", "");
            byte[] bytes;
            try { bytes = Convert.FromBase64String(trimmed); }
            catch { return false; }

            var raw = Encoding.UTF8.GetString(bytes);
            var parts = raw.Split('|');
            if (parts.Length < 5) return false;

            cityName = parts[0];
            seed     = parts[1];
            version  = parts[2];
            ip       = parts[3];
            return int.TryParse(parts[4], out port);
        }
        catch { return false; }
    }
}
