using System.Text.RegularExpressions;

namespace ReadAndWriteToFile
{
    internal class Program
    {

        struct Game
        {
            // They do not have a default contructor
            //They cannot inherit
            public string Name { get; set; }
            public string Description { get; set; }
            public int rating { get; set; }

            public void Display() 
            {
                Console.WriteLine("{0} - {1} - {2}",Name,Description,rating);
            }
        }

        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\rhant001\Downloads\sanbox-test4-logs\sanbox-test4-logs\supergwtest4.txt");
            string[] textArr = File.ReadAllLines(@"C:\Users\rhant001\Downloads\sanbox-test4-logs\sanbox-test4-logs\supergwtest4.txt");
            Console.WriteLine(text);

            File.WriteAllLines(@"C:\Users\rhant001\Downloads\supergwtest4.txt", textArr);
            Console.WriteLine("Here we are about to start");
            foreach (string line in textArr)
            {
                //Console.WriteLine(line);
            }

            string[] stringArr = File.ReadAllLines(@"C:\Users\rhant001\Downloads\input.txt");

            using(StreamWriter file = new StreamWriter(@"C:\Users\rhant001\Downloads\output.txt"))
            {
                foreach (string line in stringArr) 
                { 
                    if(line.Contains("split"))
                    {
                        string[] x = line.Split(" ");
                        file.Write(x[4]+" ");
                        Console.WriteLine("Endingggggggggggggg");
                    }
                }
            }


            string text2 = File.ReadAllText(@"C:\Users\rhant001\Downloads\input2.txt");
           // Console.WriteLine(text2);

            string test = "Hi 123 ther 34 how 5678 are 89 you78 ";

            Regex pattern = new Regex(@"[0-9]{2|3}");

            //Match collect = pattern.Matches(test);

            //Console.WriteLine(collect);
            var m1 = Regex.Matches(text2, @"[0-9]{2,3}");
            //  Console.WriteLine(m1.Count());
            //string y = "";
            string result = "";
         
            foreach (Match match in m1)
            {
                //y += match;
                //int x = (int)match.Value;
                // string x = match.Groups[1].Value;
                //Console.WriteLine(y);
                string x = match.Value.ToString();
                int y;
                bool nums = Int32.TryParse(x, out y);
                Console.WriteLine(match);
                if (nums)
                {
                    result += (char)y;
                    Console.WriteLine((char) y);
                }
                
               // Console.WriteLine();

            }

            //File.WriteAllText(@"C:\Users\rhant001\Downloads\output.txt", result);
            Console.WriteLine(result);
            /*  for(int i = 0; i < y.Length; i++)
              {

                  char c = (char) y[i];

                  Console.WriteLine(c);

              }*/

            /* Game game = new Game();
             game.Name = "Pokeman";
             game.Description = "This is a game";
             game.rating = 3;

             game.Display();

            double num;
             string y = "152";

             bool isNum = double.TryParse(y, out num);

             if(isNum && num >= 0 && num <= 180) 
             { 
                 double cosine = Math.Cos(num);
                 Console.WriteLine("Cos = {0}",cosine);
                 double sinine = Math.Sin(num);
                 Console.WriteLine("Sin = {0}", sinine);
                 double tanget = Math.Tan(num);
                 Console.WriteLine("Tg = {0}", tanget);
             }
             else
             {
                 Console.WriteLine("Check the input!");
             }*/
            Console.ReadKey();  
        }
    }
}