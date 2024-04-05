using System;

Console.Write("Enter the first line: "); 
string J = Console.ReadLine();

Console.Write("Enter the second line: ");
string S = Console.ReadLine();
    
int counter = 0;
    
for (int i = 0; i < S.Length; i++)
    for (int j = 0; j < J.Length; j++)
        if (S[i] == J[j])
        {
            counter++;
                
            break;
        }
    
Console.WriteLine(counter);