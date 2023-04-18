using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADDirectorySearcher
{
    public class LdapSearchFilter
    {
        public string GetLdapSearchFilter(string objectClass = "user", string objectCategory = "person", string nameType = Attributes.SamAccountName, bool? isDeleted = null, Dictionary<string, string> searchProperties = null, bool andSearchCriteria = true)
        {
            var safeNameType = nameType.EscapeLdapSearchFilter();
            var ldapSearchFilters = new List<string>();
            var batch = new StringBuilder();

            string booleanFilter = string.Empty;
            string filter = string.Empty;
            string ldapSearchFilter = string.Empty;
            string searchFilter = string.Empty;
            objectClass = string.IsNullOrWhiteSpace(objectClass) ? null : objectClass;
            objectCategory = string.IsNullOrWhiteSpace(objectCategory) ? null : objectCategory;
            if (objectClass != null || objectCategory != null)
            {
                filter = objectClass != null ? $"(objectClass={objectClass})" : string.Empty;
                filter = objectCategory != null && isDeleted != true ? $"{filter}(objectCategory={objectCategory})" : filter;
            }
            if (searchProperties?.Count > 0)
            {
                string safeSearchProperty = string.Empty;
                foreach (var searchProperty in searchProperties)
                {
                    var lookupName = searchProperty.Value.ToLower();

                    safeSearchProperty = searchProperty.Key.EscapeLdapSearchFilter();
                    batch.Append($"{safeSearchProperty}=" + lookupName);
                    ldapSearchFilter = $"({batch})";
                    ldapSearchFilters.Add(ldapSearchFilter);
                    batch = new StringBuilder();
                }
                booleanFilter = andSearchCriteria ? "&" : "|";
                searchFilter = $"({booleanFilter}{string.Join(null, ldapSearchFilters.ToArray())})";
                if (!string.IsNullOrEmpty(filter))
                {
                    searchFilter = $"(&{filter}{searchFilter})";
                }
            }
            else
            {
                searchFilter = filter != null ? $"(&{filter})" : "";


            }
            return searchFilter;
        }

        private static string GetLookupName(string nameType, string name)
        {
            var isSamAccountName = nameType.Equals(Attributes.SamAccountName, StringComparison.OrdinalIgnoreCase);
            if (!isSamAccountName)
            {
                return name;
            }

            var indexOf = name.IndexOf("\\", StringComparison.Ordinal);
            if (indexOf != -1)
            {
                return name.Substring(indexOf + 1);
            }

            indexOf = name.IndexOf("@", StringComparison.Ordinal);
            return indexOf > -1 ? name.Substring(0, indexOf) : name;
        }
    }
}
