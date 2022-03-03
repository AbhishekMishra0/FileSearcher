using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
    public class SearchForm
    {
        public void  Search ()
        {
            //Declaration and intialization
            string filename = "";
            List<string> filePaths = null;
            List<string> drives = null;

            filename = AcceptFileName();
            //Accept drives To Search
            drives =AcceptDrivesToSearch();
            try
            {
                filePaths = CheckIfFileIsInHistory(filename);
                DisplayFilePaths(filePaths);
            }
            catch (FileNotFoundInHistoryException)
            {
                SearchManager Manager = new SearchManager();
                filePaths = Manager.Search(filename, drives);
                if (filePaths != null)
                {
                    DisplayFilePaths(filePaths);
                }
            }

        }
        public List<string> CheckIfFileIsInHistory(string fileName)
        {
            SearchHistoryManager historyManager = new SearchHistoryManager();
            historyManager.GetSearchResults(fileName);

            return null;
        }

        public string AcceptFileName()
        {
            Console.WriteLine("Enter FileName:-");
            string filename =  Console.ReadLine();
            return filename;
        }
        public List<string> AcceptDrivesToSearch()
        { 
            IDriveFinder finder = DriveFinderFactory.Instance.Create("ALL");
            List<string> drives=finder.GetDrives();

            return null;
        }
        public void  DisplayFilePaths(List<string> filePaths)
        {

        }
    }
}
