using System;
using System.Text.RegularExpressions;

namespace PNGMetadataViewer.Utils
{
    internal class StringHelper
    {
        public static string UnescapeString(string input)
        {
            // 匹配所有转义序列，包括 \uXXXX 和 \n 等
            return Regex.Replace(input, @"\\(u[0-9A-Fa-f]{4}|n|r|t|b|f|a|v|'|""|\\)", match =>
            {
                switch (match.Value)
                {
                    case @"\n": return "\n";
                    case @"\r": return "\r";
                    case @"\t": return "\t";
                    case @"\b": return "\b";
                    case @"\f": return "\f";
                    case @"\a": return "\a";
                    case @"\v": return "\v";
                    case @"\'": return "'";
                    case @"\""": return "\"";
                    case @"\\": return "\\";
                    default:
                        // 处理 \uXXXX 转义序列
                        if (match.Value.StartsWith(@"\u"))
                        {
                            string hex = match.Value.Substring(2);
                            int codePoint = Convert.ToInt32(hex, 16);
                            return char.ConvertFromUtf32(codePoint);
                        }
                        return match.Value;
                }
            });
        }
    }
}
