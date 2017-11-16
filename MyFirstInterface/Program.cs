using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoClass info1 = new InfoClass();
            info1.Name = "Jesper";
            info1.Shoes = 47;

            IFirstinterface if1 = info1;

            Console.WriteLine(info1.GetInfo());
            Console.WriteLine(if1.GetInfo());

            //////////////////////////////
            InfoClass info2 = new InfoClass();
            info2.Name = "";
            info2.Shoes = 47;

            Object o1 = info2;              

            if (o1 is IFirstinterface)
            {
                IFirstinterface if2 =  (IFirstinterface)o1;
                Console.WriteLine(if2.GetInfo());
            }
            Console.ReadLine();
        }
        
    }
}
