using System.IO;

string wayOfInput = "C:/Users/public.COPP/Desktop/1234/уп1.4/exe2/numsTask2.txt";
using (StreamReader input = new StreamReader(wayOfInput))
{
    string numsInLine = input.ReadToEnd();
    input.Close();
    
    string[] nums1 = numsInLine.Split(';');
    float[] nums = new float[nums1.Length];
    for (int i = 0; i < nums1.Length; i ++)
    {
        float num;
        if (float.TryParse(nums1[i], out num))
            nums[i] = num;
    }

    float sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 0)
            break;
        if (nums[i] > 0)
            sum += nums[i];
    }

    Console.WriteLine($"The sum of the numbers up to zero: {Math.Round(sum, 3)}");
}