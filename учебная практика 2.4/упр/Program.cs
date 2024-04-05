using System;

while (true)
{
    Console.Write("Enter the roman numeral (0 - finish the program): ");
    string romanNumStr = Console.ReadLine();

    if (romanNumStr == "0")
        break;
        
    bool work = true;

    for (int i = 0; i < romanNumStr.Length; i++)
    {
        if (romanNumStr[i] != 'I' && romanNumStr[i] != 'V' && romanNumStr[i] != 'X' && romanNumStr[i] != 'L' &&
                romanNumStr[i] != 'C' && romanNumStr[i] != 'D' && romanNumStr[i] != 'M')
        {
            work = false;
            break;
        }
        
    }

    if (work == true)
    {
        romanNumStr += " ";

        int num = 0;
        
        for (int i = 0; i < romanNumStr.Length; i++)
        {
            if ((romanNumStr[i] == 'I' && (romanNumStr[i + 1] == 'V' || romanNumStr[i + 1] == 'X')) || 
                (romanNumStr[i] == 'X' && (romanNumStr[i + 1] == 'L' || romanNumStr[i + 1] == 'C') ||
                 (romanNumStr[i] == 'C' && (romanNumStr[i + 1] == 'D' || romanNumStr[i + 1] == 'M'))))
            {
                num += GetNum2(romanNumStr[i], romanNumStr[i + 1]);

                i++;
            }
            else
                num += GetNum1(romanNumStr[i]);
        }

        Console.WriteLine(num);
    }
    else
        Console.WriteLine("Number entered incorrectly!");
}


static int GetNum1(char sym)
{
    int num = 0;

    switch (sym)
    {
        case 'I':
        { num = 1; break; }
        case 'V':
        { num = 5; break; }
        case 'X':
        { num = 10; break; }
        case 'L':
        { num = 50; break; }
        case 'C':
        { num = 100; break; }
        case 'D':
        { num = 500; break; }
        case 'M':
        { num = 1000; break; }
    }

    return num;
}

static int GetNum2(char sym1, char sym2)
{
    int num = 0;

    switch (sym2)
    {
        case 'V':
        { num = 4; break; }
        case 'X':
        { num = 9; break; }
        case 'L':
        { num = 40; break; }
        case 'C':
        { num = 90; break; }
        case 'D':
        { num = 400; break; }
        case 'M':
        { num = 900; break; }
    }

    return num;
}