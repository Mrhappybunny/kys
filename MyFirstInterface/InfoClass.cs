using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstInterface
{
    class InfoClass : IFirstinterface
    {
        private string name;
        private int shoes;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Shoes
        {
            set { shoes = value; }
            get { return shoes;  }
        }
        public string GetInfo()
        {
            return string.Format("Hej {0} nå så du bruger nr {1} i sko.", name , shoes);
        }
        Console.ReadLine();
    }
}
