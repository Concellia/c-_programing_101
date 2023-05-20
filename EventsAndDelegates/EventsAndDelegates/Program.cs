namespace EventsAndDelegates
{
    internal class Program
    {

        public delegate bool FilterDelegate(Person person);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Person> list = new List<Person>();
            list.Add(new Person() { Age = 12, Name = "Tiyiselani" });
            list.Add(new Person() { Age = 29, Name = "Concellia" });
            list.Add(new Person() { Age = 23, Name = "Rhangani" });
            list.Add(new Person() { Age = 100, Name = "Maluleke" });
            list.Add(new Person() { Age = 49, Name = "Jimani" });

            // DisplayPeople("This is a minor",list,IsMinor);
            //Console.WriteLine(Operations.ApplyOperation(5, 2, Operations.Multiply));
            DisplayPeople("This is a lambda function",list, p =>
            {
                return p.Name == "Tiyiselanie";
            });

            Dictionary<string,Func<float,float,float>> keyValuePairs = new Dictionary<string,Func<float,float,float>>();
            Func<float,float,float> Add = (a,b) => a+b;
            Func<float, float, float> Subtract = (a, b) => a - b;
            Func<float, float, float> Divide = (a, b) => a / b;
            Func<float, float, float> Multiply = (a, b) => a * b;

            keyValuePairs.Add("+",Add); 
            keyValuePairs.Add("-",Subtract); 
            keyValuePairs.Add("/",Divide);
            keyValuePairs.Add("*",Multiply);

            var x = Operation(keyValuePairs, "*");
            

            Console.WriteLine(x(2,5));

            Console.ReadKey();

        }

        public static  void DisplayPeople(string title, List<Person> person, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in person)
            {
                if(filter(p)) Console.WriteLine("Hi my name is {0} and I am {1} years old",p.Name,p.Age);

            }
        }

        static bool IsMinor(Person person)
        {
            if(person == null) return false;
            return person.Age < 18;
        }

        static bool IsAdult(Person person)
        {
            if (person == null) return false;
            return person.Age > 18;
        }


        public static Func<float,float,float> Operation(Dictionary<string,Func<float,float,float>> dict, string sign)
        {
            if(dict.ContainsKey(sign))
            {
                return dict[sign];
            }
            else
            {
                return null;
            }
        }
    }
}