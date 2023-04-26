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
            List<string> list1 = new List<string>();
            list1.Add("one");
            list1.Add("two");
            list1.Add("three");
            List<string> list2 = new List<string>();
            list2.Add("one");
            list2.Add("two");
            list2.Add("three");
            list2.AddRange(list1);
            list2.Append("");
       
            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list.Capacity);

        }
    }
}
