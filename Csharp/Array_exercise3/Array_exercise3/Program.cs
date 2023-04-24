int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
int maxCount = 0;
int[] mostFrequent = new int[arr.Length];
int index = 0;

for (int i = 0; i < arr.Length; i++)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
        }
    }
    if (count > maxCount)
    {
        maxCount = count;
        index = 0;
        mostFrequent[index] = arr[i];
    }
    else if (count == maxCount)
    {
        index++;
        mostFrequent[index] = arr[i];
    }
}

Console.WriteLine("The elements that occur most frequently are:");
for (int i = 0; i <= index; i++)
{
    Console.WriteLine(mostFrequent[i]);
}