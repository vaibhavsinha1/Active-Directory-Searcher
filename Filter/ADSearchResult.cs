using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSearchWinForm
{
    public class ADSearchResult
    {
        public List<string> GetSearchResults(string filter, string domain, string ou, string[] propertiesToLoad, int pageSize, int sizeLimit, string sortProperty, string sortDirection)
        {
            var searchResult = new List<string>();

            var entry = new DirectoryEntry("LDAP://" + domain + "/" + ou);
            using DirectorySearcher searcher = new DirectorySearcher(entry);

            // uncomment this line if you need to search with credentials
            //searcher.Username = "username";
            //searcher.Password = "password";
            searcher.Filter = filter;
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
                    }
                }
                searchResult.Add(resultstring.TrimEnd(','));
            }
            return searchResult;
        }
    }
}

