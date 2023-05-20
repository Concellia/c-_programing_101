using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Collection
    {
        //Collection like arrays they store collection of data or objects
        //Unlike arrays collections can store different types of data at the same time
        //Unlike arrays collections are not fixed in size and they can grow as we add more data to the collection.
        //Generic colections are limited to one type of object and non generic collections can store different types of objects.

        ArrayList nonGenericCollection = new ArrayList();
        List<int> genericCollection = new List<int>();

        public static List<int> generic()
        {
            // TODO: write your solution here
            List<int> evenNumbers = new List<int>();

            for (int i = 100; i <= 170; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            }

            return evenNumbers;
        }


    }
}
