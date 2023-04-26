using sampleproject.collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject
{
    internal class Mainclass
    {
       public static void  Main(String [] args)
        {
            Array_List list = new Array_List();
            list.list();
            Linked_List linked_list = new Linked_List();
            linked_list.L_List();  
            
            list_c clist=new list_c();
            clist.list();   
                }
    }
}
