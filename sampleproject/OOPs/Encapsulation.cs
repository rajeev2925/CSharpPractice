using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.OOPs
{
    internal class Encapsulation
    {
        public int atm_pin { get; set; }       
        public void add(int atm_pin)
        { 
            this.atm_pin= atm_pin;

        }
    }
    public class display
    {
        public static void Main(string[] args)
        {
            Encapsulation en=new Encapsulation();
            en.atm_pin = 3456;
           Console.WriteLine(en.atm_pin);
            en.atm_pin = 3222;
            Console.WriteLine(en.atm_pin);
        }
    }
}
