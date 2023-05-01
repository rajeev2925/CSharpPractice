using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.OOPs
{
    public class basekeyword
    {
      public basekeyword(int a)
        {
            System.Console.WriteLine(a);
        }
    }
    public class rajeev:basekeyword
    {
       public static int a;
       public rajeev(int b):base(10)
        {
            System.Console.WriteLine(b);
        }
    }
    public class sss {
        public static void main()
        {
            rajeev r = new rajeev(2);
            rajeev.a=20;
        }
    }

    }
    

