using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Energy
    {
        public static int energy(int numberOfAnimals, int availableCapacity, int[] energyLevels)
        {
            Array.Sort(energyLevels);
            Array.Reverse(energyLevels);

            
            int[] animalsBoarding = new int[availableCapacity];

            for(int i = 0; i<numberOfAnimals; i++)
            {
                if(i < availableCapacity)
                {
                    animalsBoarding[i] = energyLevels[i];
                }
               
            }

            if(animalsBoarding.Length > 0)
            {
                return animalsBoarding[availableCapacity - 1];
            }
            return -1;
        }
    }
}
