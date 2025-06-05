using System.Linq;
using System.Net.Http;
using System.Text;

namespace CurlDebuggerVisualizer
{
    internal static class CurlRequestFormatter
    {
        public static string ToCurl(HttpRequestMessage request)
        {
            var sb = new StringBuilder();
            sb.Append("curl");

            sb.Append(" -X ").Append(request.Method);
            sb.Append(' ').Append("\"").Append(request.RequestUri).Append("\"");

            foreach (var header in request.Headers)
            {
                foreach (var value in header.Value)
                {
                    sb.Append(" -H \"").Append(header.Key).Append(": ").Append(value).Append("\"");
                }
            }

            if (request.Content != null)
            {
                foreach (var header in request.Content.Headers)
                {
                    foreach (var value in header.Value)
                    {
                        sb.Append(" -H \"").Append(header.Key).Append(": ").Append(value).Append("\"");
                    }
                }

                var body = request.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                if (!string.IsNullOrEmpty(body))
                {
                    sb.Append(" --data \"").Append(body.Replace("\"", "\\\"")).Append("\"");
                }
            }

            return sb.ToString();
        }
    }
}
