using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_101
{
    internal class UniversityManager
    {
        public List<University> Universities;
        public List<Student> Students;

        public UniversityManager() 
        { 
            Universities = new List<University>();
            Students = new List<Student>();

            Universities.Add(new University { Name = "Wits", Id = 100});
            Universities.Add(new University { Name = "UJ", Id = 200 });
            Universities.Add(new University { Name = "UCT", Id = 300 });
            Universities.Add(new University { Name = "UP", Id = 400 });

            Students.Add(new Student { Id = 1, Name = "Tiyiselani Rhangani", Age = 29, Gender = "Female", UniversityId = 100 });
            Students.Add(new Student { Id = 2, Name = "Jonh Doe", Age = 26, Gender = "Male", UniversityId = 100 });
            Students.Add(new Student { Id = 3, Name = "Jane Doe", Age = 19, Gender = "Female", UniversityId = 100 });
            Students.Add(new Student { Id = 4, Name = "Remenber Rhangani", Age = 23, Gender = "Female", UniversityId = 200 });
            Students.Add(new Student { Id = 5, Name = "Alvinah Maluleke", Age = 24, Gender = "Female", UniversityId = 200 });
            Students.Add(new Student { Id = 6, Name = "Rirhandzu Jimani", Age = 23, Gender = "Male", UniversityId = 200 });
            Students.Add(new Student { Id = 7, Name = "Mkateko Munyai", Age = 22, Gender = "Female", UniversityId = 200 });
            Students.Add(new Student { Id = 8, Name = "Hlulani Mabasa", Age = 25, Gender = "Male", UniversityId = 300 });
            Students.Add(new Student { Id = 9, Name = "Pfuno Chauke", Age = 19, Gender = "Female", UniversityId = 300 });
            Students.Add(new Student { Id = 10, Name = "Eneto George", Age = 17, Gender = "Male", UniversityId = 300 });
            Students.Add(new Student { Id = 11, Name = "Ntsako Masingita", Age = 28, Gender = "Female", UniversityId = 400 });
            Students.Add(new Student { Id = 12, Name = "Unarine Munyai", Age = 19, Gender = "Female", UniversityId = 400 });
            Students.Add(new Student { Id = 13, Name = "Meshack Maluleke", Age = 18, Gender = "Male", UniversityId = 400 });
            Students.Add(new Student { Id = 14, Name = "Florar Mahlaule", Age = 30, Gender = "Female", UniversityId = 100 });
            Students.Add(new Student { Id = 15, Name = "Mkhacani Malenga", Age = 31, Gender = "Male", UniversityId = 200 });
        }

        public void MaleStudents()
        {
            Console.WriteLine("Male Students: ");
            IEnumerable<Student> male = from student in Students where student.Gender == "Male" select student;

            foreach (Student student in male)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            Console.WriteLine("Female Students: ");
            IEnumerable<Student> female = from student in Students where student.Gender == "Female" select student;

            foreach (Student student in female)
            {
                student.Print();
            }
        }

        public void GetWitsStudents()
        {
            Console.WriteLine("Wits Students: ");
            IEnumerable<Student> witsStudents = from student in Students join university in Universities on student.UniversityId equals university.Id
                                                where university.Name == "Wits"
                                                select student;
            foreach (Student student in witsStudents)
            {
                student.Print();
            }
        }

        public void GetStudentsWithUniId()
        {
            Console.WriteLine("Please enter university ID: ");
            string input = Console.ReadLine();

            int id;
            bool isNum = int.TryParse(input, out id);

            if (isNum)
            {
                IEnumerable<Student> std = from student in Students
                                                    where student.UniversityId == id
                                                    select student;
                foreach (Student student in std)
                {
                    student.Print();
                }

            }
           
        }

        public void SortByAge()
        {
            Console.WriteLine("Sorted Students: ");
            var sortedStudent = from student in Students orderby student.Age select student;
            foreach (Student student in sortedStudent) 
            { 
                student.Print();
            }
        }
    }
}
