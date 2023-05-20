using global::System;
using global::System.Collections.Generic;



namespace InheritanceAndOOP
{
    internal class Program
    {

        public interface IShootable
        {
            public void Shoot() { }
        }

        public class Weapon : IShootable
        {
            private string Name { get; set; }

            public Weapon(string name)
            {
                this.Name = name;
            }

            public void Label()
            {
                Console.WriteLine("This is {0}!", Name);
            }

            public void Shoot()
            {
                Console.WriteLine("Shooting");
            }

        }

        public class Gun : Weapon
        {
            public Gun() : base("Gun")
            {
               
            }
        }
        static void Main(string[] args)
        {
            /* Animal animal = new Animal("Elephant",23,false);
              animal.IsHungry = false;
              animal.Age = 50;    
              animal.MakeSound();
              animal.Play();
              animal.Eat();*/

            /* Cat cat = new Cat("Brian",23,false);
             cat.IsHungry = true;
             cat.Eat();
             cat.IsHappy = true;
             cat.Play();
             cat.MakeSound();*/

            /* Post post = new Post();
             post.EditPost("Hello people of SA", true);

             Post post1 = new Post(post);

             Console.WriteLine(post.ToString());
             Console.WriteLine(post1.ToString());

             Twitter twitter = new Twitter();
             twitter.Body = "This twitter is for the South African";

             Console.WriteLine(twitter.ToString());*/

           Shelter cats = new Shelter();
            foreach (Cat cat in cats)
            {
                if(!cat.IsHappy)
                {
                    cat.Eat();
                    Console.WriteLine("{0} is not happy today.",cat.Name);
                }
                else
                {
                    cat.Play();
                    Console.WriteLine("{0} is very happy today.", cat.Name);
                }
               // Console.WriteLine(cat);
            }
            Console.ReadLine(); 
            
        }
    }
}