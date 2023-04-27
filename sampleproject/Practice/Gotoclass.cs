using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.Practice
{
    internal class Gotoclass
    {
        public void example()
        {
            comeagain:
            Console.WriteLine("enter the age");
         int age=Convert.ToInt32(Console.ReadLine());    
            if(age==0)
            {
                goto end;
            }
            if(age>18)
            {
                Console.WriteLine("YOU CAN VOTE");
            }
            else
            {
                Console.WriteLine("YOU CAN'T VOTE");
            }
            goto comeagain;
       
           end:
            Console.WriteLine("THE END");
        }
        
    }
}
