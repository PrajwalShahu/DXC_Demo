Console.WriteLine("Enter 5 digit");
long num = Convert.ToInt64(Console.ReadLine());

long sum=0;
while (num != 0)
{
    sum = sum + (num % 10);
    num = num / 10;
}
Console.WriteLine($"Sum of 5 Digit is: {sum}");
