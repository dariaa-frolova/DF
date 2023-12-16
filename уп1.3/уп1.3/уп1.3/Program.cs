using System.IO;

string way_of_input = "C:/Users/public.COPP/Desktop/1234/уп1.3/уп1.3/уп1.3/input.txt";
using (StreamReader input = new StreamReader(way_of_input))
{
    string lucky_numbers_in_line = input.ReadLine();
    int[] lucky_numbers = new int[10];
    lucky_numbers = lucky_numbers_in_line.Split(' ').Select(int.Parse).ToArray();
    
    int n = Convert.ToInt32(input.ReadLine());
    string way_of_output = "C:/Users/public.COPP/Desktop/1234/уп1.3/уп1.3/уп1.3/output.txt";
    string lucky = "Lucky", unlucky = "Unlucky";
    using (StreamWriter output = new StreamWriter(way_of_output))
    {
        for (int i = 0; i < n; i++)
        {
            string option_in_line = input.ReadLine();
            int[] option = new int[6];
            option = option_in_line.Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            for (int j = 0; j < 10; j++)
                for (int k = 0; k < 6; k++)
                    if (lucky_numbers[j] == option[k])
                        counter++;
            if (counter >= 3)
                await output.WriteLineAsync(lucky);
            else
                await output.WriteLineAsync(unlucky);
        }
    }
}