namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* BMW bmw = new BMW(150,"Yellow","BMW M3 Series");
            bmw.ShowDetails();
            bmw.Repair();
            Console.WriteLine("-------------------");
            Audi audi = new Audi(120, "Green", "Audi i30 Series");
            audi.ShowDetails();
            audi.Repair();
            Console.WriteLine("--------------------");
            Car car = new Car(100, "White");
            car.ShowDetails();
            car.Repair();*/
            Console.WriteLine("Abstraction testing--------Begins");
            Sphere sphere = new Sphere(8,"Sphere");
            sphere.GetInfo();
            Console.WriteLine(sphere.Volume());
            Console.ReadLine();
        }
    }
}