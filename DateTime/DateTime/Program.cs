namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2023,2,10);
            DateTime tomorow = DateTime.Now.AddDays(1);
            DayOfWeek dayOfTheWeek = DateTime.Now.DayOfWeek;
            DayOfWeek tom2 = tomorow.DayOfWeek;
            DateTime now = DateTime.Now;
           // Console.WriteLine("It is {0} o'clock, {1} minutes, {2} seconds and {3} miliseconds.",now.Hour,now.Minute,now.Second,now.Millisecond);
            //HowManyDays();
           

            //Creating a nullable value you need to use ?
            int? num1 = null;
            Console.WriteLine(num1);
            num1 = 2;
            Console.WriteLine(num1);

            Console.ReadKey();
        }

        public static void HowManyDays()
        {
            Console.WriteLine("Please enter date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();

            DateTime date;
            bool isDate = DateTime.TryParse(input, out date);

            if (isDate)
            {
                TimeSpan dayPassed = DateTime.Now.Subtract(date);
                Console.WriteLine("It has been {0} days since this day.",dayPassed.Days);
            }

            
        }
    }
}