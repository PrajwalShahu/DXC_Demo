﻿int[] arr = new int[] {7,4,5,6,8,2,3,1};
int max = arr[0];
for(int i=1;i<arr.Length;i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine("largest number in given array is: " + max);