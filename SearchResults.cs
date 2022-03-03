using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
    internal class SearchResults
    {
        public List<string> FilePaths { get; set; }
        public int NoOfFoldersScanned { get; set; }
    }
}
