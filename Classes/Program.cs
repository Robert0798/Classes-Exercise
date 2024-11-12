namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "R8";
            carOne.Model = "Audi";
            carOne.Year = 2020;

            Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, made in the year {carOne.Year}");
        }
    }
}
