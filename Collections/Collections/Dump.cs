using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Dump
    {
        public Dump() 
        {
            Console.WriteLine("Enter 1");
            string firstLine = Console.ReadLine();
            Console.WriteLine("Enter 2");
            string secondLine = Console.ReadLine();
            string[] firstLineArr = firstLine.Split(" ");
            int numberOfAnimals = Int32.Parse(firstLineArr[0]);
            int availableCapacity = Int32.Parse(firstLineArr[1]);
            string[] energyLevelsStr = secondLine.Split(" ");
            int[] energyLevels = energyLevelsStr.Select(int.Parse).ToArray();
            int counter = 0;
            Array.Sort(energyLevels);
            Array.Reverse(energyLevels);

            int[] animalsBoarding = new int[availableCapacity];
            if (availableCapacity > numberOfAnimals)
            {
                Console.WriteLine(-1);
            }
            for (int i = 0; i < energyLevels.Length; i++)
            {
                counter++;
                if (counter == availableCapacity)
                {
                    if (energyLevels[i] == energyLevels[i + 1])
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(energyLevels[i]);
                    }

                }



            }
        }   
    }
}
