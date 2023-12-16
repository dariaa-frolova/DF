using System.Collections.Generic;
List<int> nums = new List<int>();
Console.WriteLine("Enter the numbers:");
while (true)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 0)
        break;
    nums.Add(input);
}
int sum = 0;
int product = 1;
int arithMean = 0;
foreach (int num in nums)
{
    sum += num;
    product *= num;
}
arithMean = sum / nums.Count;
Console.WriteLine($"The sum of numbers: {sum}; the product of numbers: {product}; the arithmetic mean of numbers: {arithMean}");