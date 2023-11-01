namespace InterviewCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 50;  i <= 400;  i++) 
            {
                Console.WriteLine(i);
                if ((i % 6  == 0) && (i%9==0))
                {
                    count++;
                }
            }
            Console.WriteLine("Here we are: ");
            Console.WriteLine(count);
        }
    }
}