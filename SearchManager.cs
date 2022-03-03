using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
    internal class SearchManager
    {
        protected SearchHistoryManager HistoryManager { get; set; } 

        public SearchManager()
        {
            HistoryManager = new SearchHistoryManager();
        }
        public List<string> Search (string fileName,List<string> drives)
        {
            StoreSearchResultsInHistory();
            return null;
        }
        public void StoreSearchResultsInHistory () 
        {
            HistoryManager.StoreSearchResults();
             
        }
    }
}
