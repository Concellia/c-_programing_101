using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_101
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Name { get; set;}
        public string? Gender { get; set;}
        public int Age { get; set; }

        //Foreign key
        public int UniversityId { get; set;}

        public void Print()
        {
        
            Console.WriteLine("{0} is a {1} student at a University with ID: {2} and is {3} years old, with ID: {4}.",Name,Gender,UniversityId,Age,Id);
        }



    }
}
