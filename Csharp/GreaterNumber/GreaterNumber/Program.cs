Console.WriteLine("enter first numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter Third number");
int num3  = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("First number is greater");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("Second Number is greater");
}
else
{
    Console.WriteLine("Thrid number is greater");
}
