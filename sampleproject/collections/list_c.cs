using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.collections
{
    internal class list_c
    {
       public void list()
        {
           
            List<string> list = new List<string>();     
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("three");
            List<string> list2 = new List<string>();
            list2.Add("one");
            list2.Add("two");
            list2.Add("three");
            list2.AddRange(list2);
            list2.Append("");
            list2.Insert(1, "raj");
            list2.Sort();
           Console.WriteLine( "element:"+list2.ElementAt(0));
          Console.WriteLine("equals "+list2.Equals(list2));
            Console.WriteLine("to String :"+list2.ToString());
       
            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list.Capacity);

        }
    }
}
