using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.OOPs
{
    internal class polymorizm2
    {
        public virtual void whatsapp()
        {
            System.Console.WriteLine("super class");
        }
    }
    internal class base_class:polymorizm2
    {
        public override void whatsapp()
        {
            System.Console.WriteLine("base class");
        }
    }

    public class mclass
    {
        public static void main(string[] args)
        {
            base_class bs=new base_class();
            bs.whatsapp();
        }
    }
}
