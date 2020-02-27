using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLightboard.Helpers
{
    public static class StringHelper
    {
        public static string Truncate(this string text, int length, bool useEllipsis, string ellipsis = "...", bool keepFullWordAtEnd = false)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;

            if (text.Length < length) return text;

            text = text.Substring(0, length);

            if (keepFullWordAtEnd)
            {
                text = text.Substring(0, text.LastIndexOf(' '));
            }

            if (!useEllipsis) return text;

            return text + ellipsis;
        }
    }
}
