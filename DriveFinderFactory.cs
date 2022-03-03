using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
    public class DriveFinderFactory
    {
        public static  DriveFinderFactory Instance { get; set; }

        static DriveFinderFactory()
        {
            Instance = new DriveFinderFactory();    
        }
        public  IDriveFinder Create(string choice)
        {
            IDriveFinder finder = null;

            if (choice.Equals("All"))
                finder = new AllDriveFinder();
            else if (choice.Equals("SYSTEM"))
                finder = new SystemdriveFinder();
            else
                throw new InvalidFinderChoiceException();
            return finder;


        }
    }
}
