using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.collections
{
    internal class Linked_List
    {
        public void L_List()
        { 
        LinkedList<String> list = new LinkedList<String>();
            list.AddFirst("rajeeva");
            list.AddLast("naga");
            list.AddFirst("vinu");
            list.AddFirst("some");
            list.Remove("NAGA");
            list.ElementAt(0);
            Console.WriteLine("linked list data");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("after the adding new data");
             LinkedListNode<String> node=list.Find("naga");
            list.AddBefore(node, "hani");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            list.Remove("some");
            Console.WriteLine();
            Console.WriteLine("after the removing new data");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}
