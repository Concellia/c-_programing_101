using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("The name of the shape is {0}",Name);
        }

        public abstract double Volume();
    }
}
