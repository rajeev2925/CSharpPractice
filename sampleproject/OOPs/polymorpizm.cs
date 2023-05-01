using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.OOPs
{
    internal class polymorpizm
    {
        public void Add1(int a)
        {
            Console.WriteLine(a);
        }
        public void Add2(int b,String name)
        {
            Console.WriteLine(b + " " + name);
        }
        public void Add3(int c,String add)
        {
            Console.WriteLine(add + " " + c);
        }
    }
    public class pclass
    {
        public static void main(String[] args)
        {
            polymorpizm pm=new polymorpizm();   
            pm.Add1(1);
            pm.Add2(3, "rajeev");
            pm.Add3(4, "naga");
        }
    }


}
