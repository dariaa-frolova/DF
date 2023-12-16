using System;
using System.IO;

namespace exe2;

class Program
{
    public static async Task Main(string[] args)
    {
        string way_of_nums = "C:/Users/public.COPP/Desktop/1234/уп1.3/уп1.3/exe2/nums.txt";
        using (StreamReader input = new StreamReader(way_of_nums))
        {
            string nums_in_line = input.ReadLine();
            input.Close();
            string[] nums = nums_in_line.Split(' ');
            using (StreamWriter output = new StreamWriter(way_of_nums))
            {
                foreach (var number in nums)
                {
                    int num;
                        if (int.TryParse(number, out num))
                            if (num % 2 != 0)
                                output.Write(num + " ");
                }
            }
        }
    }
}


