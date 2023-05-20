using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Hashtable table = new Hashtable();
            table.Add("Name", "Tiyiselani");
            table.Add("Surname", "Rhangani");
            table.Add("Age", 29);
            table.Add("Job", "Software Engineer");
            table.Add("Salary", "32000.00");
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

            StacksAndQueues.stackMethod();
            Console.WriteLine("Next line");
            StacksAndQueues.queueMethod();

            /* if (animalsBoarding.Length > 0)
             {
                 Console.WriteLine(animalsBoarding[availableCapacity - 1]);
             }
             else { Console.WriteLine(-1); }*/
        }
    }
}