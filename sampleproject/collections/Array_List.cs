using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject
{
    internal class Array_List
    {
        public void list()
        {
          ArrayList arrayList = new ArrayList();
            // adding the data to arralist
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("rajeev");
            arrayList.Add(2.0);
            arrayList.Add(1); 
            arrayList.Add(1);
            
            //after adding data printing the data
            foreach(var alist in arrayList)
            {
                Console.WriteLine(alist);
            }
            Console.WriteLine();
            //removing the data from arraylist
            arrayList.Remove(2.0);
            arrayList.RemoveAt(0);

            // after adding data printing the data
            foreach (var alist in arrayList)
            {
                Console.WriteLine(alist);
            }
            Console.WriteLine();
        }

    }
}
