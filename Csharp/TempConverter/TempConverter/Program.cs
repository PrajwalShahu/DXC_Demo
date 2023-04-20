using System.Runtime.CompilerServices;

namespace TempConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Tempreature in celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit;

            Fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Tempreature in Fahrenheit is:" + Fahrenheit);
        }
    }
}