Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the operator (+,-,/,*,%)");
char op = Convert.ToChar(Console.ReadLine());
switch(op)
{
    case '+':
        {
            int res= num1 + num2;
            Console.WriteLine("sum is: "+res);
            break;
        }
    case '-':
        {
            int res = num1 - num2;
            Console.WriteLine("difference is: "+res);
            break;
        }
    case '/':
        {
            int res = num1 / num2;
            Console.WriteLine("division is: "+res);
            break;
        }
    case '*':
        {
            int res = num1 * num2;
            Console.WriteLine("Multiple is: " + res);
            break;
        }
    case '%':
        {
            int res = num1 % num2;
            Console.WriteLine("Mode is: " + res);
            break;
        }
    default:
        {
            Console.WriteLine("Invalid operator");
            break;
        }
}
