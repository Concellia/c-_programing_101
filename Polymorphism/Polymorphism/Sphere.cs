using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Sphere : Shape
    {
        public double Diameter { get; set; }

        public Sphere(double diameter, string name) 
        {
            this.Name = name;
            this.Diameter = diameter;
        }
        public override double Volume()
        {
            
            return (4/3)*Math.PI*(Math.Pow((Diameter/2), 3));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The Diameter is {0}",Diameter);
        }
    }
}
