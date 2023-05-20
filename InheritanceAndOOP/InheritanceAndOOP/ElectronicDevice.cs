using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class ElectronicDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectronicDevice(bool IsOn, string Brand)
        {
            this.IsOn = IsOn;
            this.Brand = Brand;
        }

        public void SwitchOn() { this.IsOn = true; }
        public void SwitchOff() { this.IsOn = false; }

    }
}
