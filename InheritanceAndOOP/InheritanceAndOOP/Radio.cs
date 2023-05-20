using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class Radio: ElectronicDevice
    {


        public Radio(bool IsOn, string Brand) : base(IsOn, Brand) { }

        public void ListenToRadio() 
        {
            if(this.IsOn)
            {
                Console.WriteLine("You are currently listening to the radio.");
            }
            else
            {
                Console.WriteLine("Radio currently off, please switch it on");
            }
        }
    }
}
