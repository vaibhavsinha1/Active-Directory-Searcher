using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ADDirectorySearcher
{
    public static class StringExtensions
    {
        public static int? ToNullableInt(this string s)
        {
            if (int.TryParse(s, out var i))
            {
                return i;
            }

            return null;
        }

        public static string EscapeLdapSearchFilter(this string searchFilter)
        {
            var escape = new StringBuilder();
            foreach (var current in searchFilter)
            {
                switch (current)
                {
                    case '\\':
                        escape.Append(@"\5c");
                        break;
                    case '*':
                        escape.Append(@"\2a");
                        break;
                    case '(':
                        escape.Append(@"\28");
                        break;
                    case ')':
                        escape.Append(@"\29");
                        break;
                    case '\u0000':
                        escape.Append(@"\00");
                        break;
                    case '/':
                        escape.Append(@"\2f");
                        break;
                    default:
                        escape.Append(current);
                        break;
                }
            }

            return escape.ToString();
        }

        public static string EscapeNameFilter(this string name)
        {
            var escape = new StringBuilder();
            foreach (var current in name)
            {
                switch (current)
                {
                    case '\\':
                    case ',':
                    case ';':
                    case '"':
                    case '=':
                    case '+':
                    case '<':
                    case '>':
                    case '#':
                        escape.Append(@"\");
                        escape.Append(current);
                        break;
                    default:
                        escape.Append(current);
                        break;
                }
            }

            return escape.ToString();
        }

        public static bool Contains(this string value, string toCheck, StringComparison comparison)
        {
            return value.IndexOf(toCheck, comparison) >= 0;
        }

        public static string GetOuPathFromDn(this string value)
        {
            const string ouSeparator = "OU=";
            var startIndex = value.IndexOf(ouSeparator, StringComparison.OrdinalIgnoreCase);

            if (startIndex < 0)
            {
                return null;
            }

            return value.Substring(startIndex);
        }

        public static string GetDomainFromDn(this string value)
        {
            const string dcSeparator = ",DC=";
            return value.Split(new[] { dcSeparator }, StringSplitOptions.None)[1];
        }

        public static string ToBinarySid(this string value)
        {
            var sid = new SecurityIdentifier(value);
            var bytes = new byte[sid.BinaryLength];
            sid.GetBinaryForm(bytes, 0);

            var hexBytes = Array.ConvertAll(bytes, b => b.ToString("X2", NumberFormatInfo.InvariantInfo));
            return string.Concat(hexBytes);
        }

        public static string SafeSubstring(this string text, int start, int length) /* https://stackoverflow.com/questions/2021498/problem-with-substring-argumentoutofrangeexception */
        {
            return text == null || text.Length <= start || start < 0 || length < 0 ? string.Empty
                : text.Length - start <= length ? text.Substring(start)
                : text.Substring(start, length);
        }

        public static Dictionary<string,string> GetStringAsDictionary(this string value){

            var itemDic = new Dictionary<string,string>();
            if (!string.IsNullOrEmpty(value))
            {
                var itemsList = value.Split(';');
                if (itemsList.Length > 0)
                {
                    foreach (var item in itemsList)
                    {
                        var itemsplit = item.Split(',');
                        if (itemsplit.Length > 0)
                        {
                            itemDic.Add(itemsplit[0].Trim(), itemsplit[1].Trim());
                        }
                    }
                }
            }
            return itemDic;
        }
    }
}
