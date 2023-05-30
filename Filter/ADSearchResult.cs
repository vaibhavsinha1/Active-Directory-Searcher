using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADSearchWinForm
{
    public class ADSearchResult
    {
        public List<string> GetSearchResults(string filter, string domain, string ou, string[] propertiesToLoad, int pageSize, int sizeLimit, string sortProperty, string sortDirection, string userName, string password, bool includeDeleted)
        {
            var searchResult = new List<string>();
            DirectoryEntry entry = null;
            if (!string.IsNullOrEmpty(ou))
            {
                entry = new DirectoryEntry("LDAP://" + domain + "/" + ou);
            }
            else
            {
                entry = new DirectoryEntry("LDAP://" + domain);
            }

            // uncomment this line if you need to search with credentials
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                entry.Username = userName;
                entry.Password = password;
            }

            using DirectorySearcher searcher = new DirectorySearcher(entry);

            if (!includeDeleted)
            {
                searcher.Filter = filter;
            }
            searcher.PropertiesToLoad.AddRange(propertiesToLoad);
            int offset = 1;
            if (sizeLimit > 0)
            {
                searcher.SizeLimit = sizeLimit;
            }
            if(pageSize == 0)
            {
                pageSize = int.MaxValue;
            }

            if (includeDeleted)
            {
                searcher.Tombstone = true;
            }

            searcher.SearchScope = SearchScope.Subtree;
            SortDirection sort = sortDirection == "ASC" ? SortDirection.Ascending : SortDirection.Descending;
            searcher.Sort = new SortOption(sortProperty, sort);
            DirectoryVirtualListView view = new DirectoryVirtualListView(0, pageSize, offset);
            searcher.VirtualListView = view;
            SearchResultCollection results = searcher.FindAll();
            searchResult.AddRange(GetSearchResultSet(results, propertiesToLoad));
            offset += pageSize + 1;
            while (offset < searcher.VirtualListView.ApproximateTotal)
            {
                //update our offset and continue to search
                searcher.VirtualListView.Offset = offset;
                results = searcher.FindAll();
                searchResult.AddRange(GetSearchResultSet(results, propertiesToLoad));
                offset += pageSize + 1;
            }
            return searchResult;
        }

        private List<string> GetSearchResultSet(SearchResultCollection searchResultCollection, string[] propertiesToLoad)
        {
            int flags;
            List<string> searchResult = new List<string>();
            string resultstring;
            foreach (SearchResult result in searchResultCollection)
            {
                resultstring = string.Empty;
                foreach (var property in propertiesToLoad)
                {
                    if (result.Properties.Contains(property))
                    {
                        resultstring += $"{property} = {result.Properties[property][0]} , ";
                        if(property.Equals("userAccountControl",StringComparison.OrdinalIgnoreCase))
                        {
                            if (int.TryParse(result.Properties[property][0].ToString(), out flags))
                            {
                                resultstring += $"Enabled = {!Convert.ToBoolean(flags & 0x0002)} , ";
                            }
                        }
                    }
                }
                searchResult.Add(resultstring.TrimEnd(','));
            }
            return searchResult;
        }
    }
}

