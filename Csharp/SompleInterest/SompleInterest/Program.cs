Console.WriteLine("Enter Principle Balance");
double p = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter annual Interest rate");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter time in years");
double t = Convert.ToDouble(Console.ReadLine());
double a, i;

i = (p * r * t) / 1000;
a = p*(1 + (r * t));

Console.WriteLine("Simple Interest" + i);
Console.WriteLine("Final amount" + a);
