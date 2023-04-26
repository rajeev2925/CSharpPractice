using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.collections
{
    internal class Sorted_list
    {
        public void S_list()
        {
            //creating Empty sortedlist

            SortedList<int,string> slist=new SortedList<int,string>();
            
            //adding element to sorted list
            slist.Add(1, "rajeeva");
            slist.Add(4, "xyz");
            slist.Add(3, "rajeev");
            slist.Add(2, "xyzg");
            slist.Remove(4);
            slist.ElementAt (4);
            
           
                       //printing the sorted list

            foreach (KeyValuePair<int,string> kv in slist)
            {
               Console.WriteLine(kv.Key+" "+kv.Value);
            }

        }
    }
}
