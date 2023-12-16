int[] arr = new int[10];

Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
    if (min > arr[i])
        min = arr[i];
Console.WriteLine($"Minimum element of array: {min}");
