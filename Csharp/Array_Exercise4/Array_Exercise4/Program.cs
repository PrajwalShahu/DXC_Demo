int[] arr = new int[10];
Console.WriteLine("Enter the numbers in array");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = arr[0];
for  (int i = 1;i < arr.Length; i++)
{
    sum = sum + arr[i];
}
int avg =sum / arr.Length;
Console.WriteLine($"average of the elements in the given array is {avg}");
