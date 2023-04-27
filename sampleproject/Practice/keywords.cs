using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.Practice
{
    internal class Keywords
    {
        public enum  csharpstudents
        {
             rajeev,
             raja,
             abhi,
             lakshmi
        }
        public struct Person
        {
            // Declaring different data types
            public string Name;
            public int Age;
            public int Weight;

        }
        public void add_data()
        {
            Person p1;
            p1.Name = "rajeev";
            p1.Age = 18;
            p1.Weight = 65;
            Console.WriteLine(p1.Name+" "+p1.Age+" "+p1.Weight);
        }


    }
}
