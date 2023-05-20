using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class Cat: Animal
    {
        public bool IsHappy;
        public Cat(string name, int age, bool isHungry,bool isHappy): base(name,age,isHungry) 
        {
            IsHappy = isHappy;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mweeeee Mweeee");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine("Very sad to play.");
            }
            
        }
    }
}
