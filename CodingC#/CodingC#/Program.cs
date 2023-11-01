namespace CodingC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<int> list = new List<int> { 3, 8, 2, 4, 1, 5,1,5,-2,5,3,100,56,487,963,5,5,4,-50,200 };
             List<int> bubble = BubbleSort.Sort(list);

              foreach (int i in bubble) 
              { 
                  Console.WriteLine(i);
              }*/

            // Console.WriteLine(StringReverse.reverse("Tiyiselani"));
            // Console.WriteLine(StringReverse.reverseRec("Tiyiselani"));
            // Console.WriteLine(NumberReverse.reverseNum(102354));
            // Console.WriteLine(StringLength.Length("Tiyiselani"));

            // Console.WriteLine(BubbleSort.Sort(list));
            //Console.WriteLine(Factorial.factLoop(5));

            /*int num1 = 13;
            int num2 = 16;

            Console.WriteLine(num1);
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine(num1);*/

            int[] ints = { 1,2,2,3,3,3,4,4,4,4};
            Dictionary<int,string> result = Frequency.count(ints);

            foreach (var i in result)
            {
                Console.WriteLine("{0} - occurs {1}",i.Key,i.Value);

            }
            Console.ReadKey();
        }
    }
}