
char choice;
do
{
    Console.Write("Enter temperature in Celsius: ");
    double celsius = Convert.ToDouble(Console.ReadLine());

    double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
    Console.WriteLine($"{celsius} degrees Celsius is {fahrenheit} degrees Fahrenheit.");

    Console.Write("Do you want to continue? (y/n) ");
    choice = Convert.ToChar(Console.ReadLine());
} while (choice == 'y' || choice == 'Y');
