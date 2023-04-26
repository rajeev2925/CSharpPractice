using sampleproject.collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject
{
    internal class Mainclass
    {
       public static void Main(String [] args)
        {
            Assignments assignments = new Assignments();
            assignments.Hash_set();
            assignments.Sorted_set();
            assignments.Stacks();
            assignments.Queues();
            assignments.Dictionary_col();
            assignments.SortedDictionary_col();
        }
    }
}
