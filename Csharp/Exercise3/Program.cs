Console.WriteLine("Enter the 5 numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = Convert.ToInt32(Console.ReadLine());
int num5 = Convert.ToInt32(Console.ReadLine());
double Sum, Avg;

Sum = num1+num2+num3+num4+num5;
Avg = (num1+num2+num3+num4+num5)/5;

Console.WriteLine("sum of numbers is:"+ Sum);
Console.WriteLine("Avg of numbers is:"+ Avg);
