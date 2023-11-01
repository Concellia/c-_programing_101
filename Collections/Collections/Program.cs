using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Collections
{

    class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int studentCount = 0;

            while (studentCount < 3)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(" ");

                if (inputArr.Length == 2)
                {
                    string firstName = inputArr[0];
                    string lastName = inputArr[1];

                    Student s = new Student { LastName = lastName, FirstName = firstName };

                    students.Add(s);
                    studentCount++;
                }
                else
                {
                    Console.WriteLine("Invalid input format. Please enter both first and last names.");
                }
            }


            var sortedStudents = from student in students
                                 orderby student.LastName, student.FirstName
                                 select student;

            List<string> processedFirstNames = new List<string>();
            List<string> x = new List<string>();

            foreach (var student in sortedStudents)
            {
                if (!processedFirstNames.Contains(student.FirstName))
                {
                    processedFirstNames.Add(student.FirstName);
                }
                else
                {
                    x.Add(student.FirstName);
                }
            }
            foreach (var student in x)
            { 
                foreach (var student2 in sortedStudents)
                {
                    if(student2.FirstName == student)
                    {
                        Console.WriteLine($"{student2.FirstName} {student2.LastName}");
                    }
                    else
                    {
                        Console.WriteLine(student2.FirstName);
                    }

                }

            }






            //JaggedArray.anArray();

            //int[] happiness = { 1,8,2,7,3,7,9 };


            //int[] doubleHapiness = ArrayParam.Happines(happiness);

            /* Console.WriteLine("Happiness below: ");
             foreach (int item in happiness)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine("Hapiness has doubled: ");
             foreach (int i in doubleHapiness)
             {
                 Console.WriteLine(i);
             }*/

            //Console.WriteLine(Energy.energy(7, 3, happiness));

            //Console.WriteLine("Hello, World!");

            //Params.ParamMethodString("Hi","my","name ","is Tiyiselani.");
            //Params.ParamMethodObj(1, true, 'A', "Hello", 0.25, 53);

            //Hashtable table = new Hashtable();
            //table.Add("Name", "Tiyiselani");
            //table.Add("Surname", "Rhangani");
            //table.Add("Age", 29);
            //table.Add("Job", "Software Engineer");
            // table.Add("Salary", "32000.00");
            //int[] numbers = { 1,2,3,4};
            //double math = Mathematics.AVG(numbers);
            //Console.WriteLine(table["Name"]);

            /*foreach (string key in table.Keys)
            {
                Console.WriteLine(table[key]);
            }

            foreach (DictionaryEntry i in table)
            {
                Console.WriteLine(i.Value);
            }*/

            //Console.WriteLine(Dict.Convert(6));

            // StacksAndQueues.stackMethod();
            //Console.WriteLine("Next line");
            //StacksAndQueues.queueMethod();

            /* if (animalsBoarding.Length > 0)
             {
                 Console.WriteLine(animalsBoarding[availableCapacity - 1]);
             }
             else { Console.WriteLine(-1); }*/
        }
    }
}