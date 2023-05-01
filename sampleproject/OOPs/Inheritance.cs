using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.OOPs
{
    public class Inheritance
    {
        public void add()
        {
            int id = 01;
            String name = "rajeev";
            Console.WriteLine(id + "  " + name);
        }
    }
    public class Base_class : Inheritance
    {
        public void ex()
        {
            String adress = "hassan";
            Console.WriteLine(adress);
        }
    }

    public class Main_Class
    {
        public static void main()
        {
            Base_class bs=new Base_class();
            bs.add();
            bs.ex();
                    
        }
    }
}