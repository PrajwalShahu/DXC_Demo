Console.WriteLine("Enter Student ID");
int ID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Student Name");
string Name = Console.ReadLine();
Console.WriteLine("Enter Student Age");
int Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Mark 1");
int M1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Mark 2");
int M2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Mark 3");
int M3 = Convert.ToInt32(Console.ReadLine());
double Total, Per;
int overall_marks = 300;


Total = M1 + M2 + M3;
Per = (Total / overall_marks) * 100;

Console.WriteLine("Your Total score is: " + Total);
Console.WriteLine("Your Percentage is: " + Per);

if (Per > 50)
{
    if(Per >= 90 && Per <=100)
    {      
        Console.WriteLine("your Grade is: A");
        Console.WriteLine("Your Result For the exam is PASS");
    }
    else if (Per >= 80 && Per <= 89)
    {
        Console.WriteLine("your Grade is: B");
        Console.WriteLine("Your Result For the exam is PASS");
    }
    else if (Per >= 60 && Per <= 79)
    {
        Console.WriteLine("your Grade is: C");
        Console.WriteLine("Your Result For the exam is PASS");
    }
    else if (Per >= 50 && Per <= 59)
    {
        Console.WriteLine("your Grade is: D");
        Console.WriteLine("Your Result For the exam is PASS");
    }
}
else
{
    Console.WriteLine("your Grade is: E");
    Console.WriteLine("Your Result For the exam is FAIL");
}