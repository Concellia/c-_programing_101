using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class TV: ElectronicDevice
    {
    

        public TV(bool IsOn, string Brand): base(IsOn, Brand){}

        public void ListenToTV()
        {
            if (this.IsOn)
            {
                Console.WriteLine("You are currently listening to the TV.");
            }
            else
            {
                Console.WriteLine("TV currently off, please switch it on");
            }
        }
    }
}
