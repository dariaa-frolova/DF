﻿using System.IO;
using System.Collections.Generic;

string wayOfInput = "C:/Users/public.COPP/Desktop/1234/уп1.3/уп1.3/exe3/input.txt";
using (StreamReader input = new StreamReader(wayOfInput))
{
    string numsInLine = input.ReadLine();
    input.Close();
    string[] height1 = numsInLine.Split(' ');
    int i = height1.Length;
    int[] height = new int[i];
    for (int k = 0; k < i; k++)
    {
        int num;
        if (int.TryParse(height1[k], out num))
            height[k] = num;
    }
    string wayOfOutput = "C:/Users/public.COPP/Desktop/1234/уп1.3/уп1.3/exe3/output.txt";
    using (StreamWriter output = new StreamWriter(wayOfOutput))
    {
        int width;
        List<int> squares = new List<int>();
        for (int j = 0; j < i; j++)
        {
            for (int k = 1; k < i; k++)
            {
                width = Int32.Abs(j - k);
                if (height[j] > height[k])
                    squares.Add(height[k] * width);
                else if (height[j] < height[k])
                    squares.Add(height[j] * width);
                else
                    squares.Add(height[k] * width);
            }
        }

        int maxsquare = squares[0];
        for (int k = 0; k < squares.Count; k++)
            if (squares[k] > maxsquare)
                maxsquare = squares[k];
        output.WriteLine(maxsquare);
    }

}