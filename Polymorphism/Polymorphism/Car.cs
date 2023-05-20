﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        public void  ShowDetails()
        {
            Console.WriteLine("The HP is {0} and the color is {1}.",HP,Color);
        }

     /*   public sealed override void Changed()
        {

        }*/

        public virtual void Repair() 
        { 
            Console.WriteLine("Car was repaired"); 
        }
    }
}
