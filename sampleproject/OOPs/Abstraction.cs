using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.OOPs
{
    public interface vidmate
    {
        public void app();
    }
    public abstract class raj
    {
        public virtual void app1()
        {
            Console.WriteLine("virtual method");
        }
    }
    public class Abstraction : raj, vidmate
    {
        public void app()
        {
            System.Console.WriteLine("some apps");
        }
        public override void app1()
        {
            System.Console.WriteLine("override method");
        }
    }
    public class mc
    {
        public static void Main()
        {
            Abstraction ab=new Abstraction();
            ab.app1();
            ab.app();
        }
    }
}
