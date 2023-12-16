Console.WriteLine("Enter begin of range");
int begin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter end of range");
int end = Convert.ToInt32(Console.ReadLine());
int[] nums = Completion(begin, end);
foreach (int num in nums)
{
    Console.Write(num + " ");
}

int[] Completion(int begin, int end)
{
    int[] nums = new int [10];
    Random random = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = random.Next(begin, end);
    }
    return nums;
}
