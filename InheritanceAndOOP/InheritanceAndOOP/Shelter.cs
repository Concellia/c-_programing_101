using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class Shelter: IEnumerable<Cat>
    {
        public List<Cat> cats;
        public Shelter()
        {
            cats = new List<Cat>()
            { 
            new Cat("Penny",12,false,true),
            new Cat("Sharon",30,false,false),
            new Cat("Helga",16,true,false),
            new Cat("Daria",36,true,true),
            new Cat("Josh",12,false,true),
            new Cat("Alden",32,false,false),
            new Cat("Anorld",16,true,true),
            new Cat("Trent",40,false,true)
            };

        }

        IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
        {
            return cats.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
