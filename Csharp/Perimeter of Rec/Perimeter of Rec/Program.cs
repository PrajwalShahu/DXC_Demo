namespace Perimeter_of_Rec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Lenght of Rectangle");
            double Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Breath of Rectangle");
            double Breath = Convert.ToDouble(Console.ReadLine());

            double Perimeter = 2 * (Length + Breath);

            Console.WriteLine(Perimeter);
        }
    }
}