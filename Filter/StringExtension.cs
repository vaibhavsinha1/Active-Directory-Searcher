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
