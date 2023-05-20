using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BMW: Car
    {
        private string Brand = "BMW";
        public string Model { get; set; }
        public BMW(int HP,string Color, string Model):base(HP,Color) 
        { 
                this.Model = Model;
                
        }

        public new void ShowDetails()
        {
            Console.WriteLine("The brand is {0}, the Model is {1}, HP is {2} and the color is {3}.",this.Brand,this.Model,this.HP,this.Color);
        }

        public override void Repair()
        {
            Console.WriteLine("{0} has been repaired.",Model);


        }
    }
}
