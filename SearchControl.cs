using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
    internal class SearchControl
    {

        public int counter = 0;
        private static SearchControl instance = null;
        public static SearchControl GetInstance
        {
             get
             {
                if (instance == null)
                    instance = new SearchControl();
                return instance;
             }
        }
        private SearchControl()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public bool performSearch()
        {
            return true;
        }

        //Thread thr1 = new Thread(method1);
        //Thread thr2 = new Thread(method2);
        //thr1.Start();
        //thr2.Start();




    }
}
