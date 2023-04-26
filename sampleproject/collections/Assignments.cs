using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.collections
{
    internal class Assignments
    {
        public void Hash_set()
        {
            Console.WriteLine("**HASHSET***");
            HashSet<string> set = new HashSet<string>();
            set.Add("a");
            set.Add("b");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(set.Contains("b"));
            set.Remove("b");
            set.ElementAt(0);
            set.Count();
            set.First();
            set.Last();
        }

        //===========================================================================================
        public void Sorted_set()
        {
            Console.WriteLine("**SORTEDSET***");
            SortedSet<int> set = new SortedSet<int>();
            set.Add(1);
            set.Add(2);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(set.Contains(1));
            set.Remove(1);
            set.ElementAt(0);
            set.Count();
            set.First();
        }

        //===========================================================================================
        public void Stacks()
        {
            Console.WriteLine("**STACK***");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Contains(1);
            stack.Pop();
            stack.Peek();
            stack.Count();
            stack.First();
        }

        //===========================================================================================
        public void Queues()
        {
            Console.WriteLine("**QUEUE***");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Contains(2);
            queue.Dequeue();
            queue.Peek();
            queue.Count();
            
        }

        //===========================================================================================
        public void Dictionary_col()
        {
            Console.WriteLine("**DICTIONARY***");
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "a");
            dict.Add(2, "b");
            foreach(KeyValuePair<int,string> pair in dict)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
            dict.ContainsKey(1);
            dict.ContainsValue("a");
            dict.Remove(1);
            dict.ElementAt(1);
            dict.Reverse();
            dict.Count();
            dict.First();
        }

        //===========================================================================================
        public void SortedDictionary_col()
        {
            Console.WriteLine("**SORTEDDICTIONARY***");
            SortedDictionary<int,string> keyValuePairs = new SortedDictionary<int,string>();
           keyValuePairs.Add(1, "b");
            keyValuePairs.Add(2, "a");
            foreach (KeyValuePair<int, string> pair in keyValuePairs)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
            keyValuePairs.ContainsKey(1);
            keyValuePairs.ContainsValue("a");
            keyValuePairs.Remove(1);
            keyValuePairs.Count();
        }
        //===========================================================================================

    }
}
