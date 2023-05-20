using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class Animal
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age, bool isHungry) 
        { 
            this.Name = name;
            this.Age = age;
            this.IsHungry = isHungry;
        
        }
        //Virtual means any class that will inherit from this class can overide this method.
        public virtual void Eat() 
        { 
            if(IsHungry)
            {
                Console.WriteLine("{0} is humgry and eating",Name);
            }
            else
            {
                Console.WriteLine("{0} is not yet humgry and will eat later.", Name);
            }
        }

        public virtual void Play()
        {
            if (Age > 35)
            {
                Console.WriteLine("{0} is {1} years old and tired cannot play, needs to rest.", Name,Age);
            }
            else
            {
                Console.WriteLine("{0} is {1} years old and playing.", Name,Age);
            }
        }

       
        public virtual void MakeSound() 
        {
            Console.WriteLine("Making animal sounds");
        }
    }
}
