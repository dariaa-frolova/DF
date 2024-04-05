using System;

namespace упр3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculation line = new Calculation();
            line.SetCalculationLine();

            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("-------------\nChoose the command:\n1 - set the line\n2 - append a symbol to the end of a line\n3 - print the line\n4 - get the last symbol\n5 - delete the last symbol\n6 - finish the program\n-------------");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                    {
                        line.SetCalculationLine();
            
                        break;
                    }
                    case "2":
                    {
                        line.SetLastSymbolCalculationLine();
            
                        break;
                    }
                    case "3":
                    {
                        line.GetCalculationLine();
            
                        break;
                    }
                    case "4":
                    {
                        Console.WriteLine($"Last symbol: {line.GetLastSymbol()}");
            
                        break;
                    }
                    case "5":
                    {
                        line.DeleteLastSymbol();
            
                        break;
                    }
                    case "6":
                    {
                        isWork = false;
            
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("There is no such command!");
            
                        break;
                    }
                }
            }

        }
    }

    public class Calculation
    {
        public string calculationLine { get; set; }

        public string SetCalculationLine()
        {
            Console.Write("Enter the new line: ");
            calculationLine = Console.ReadLine();
            
            return calculationLine;
        }

        public string SetLastSymbolCalculationLine()
        {
            char symbol;
            
            while (true)
            {
                Console.Write("Enter the symbol: ");
                string symbolStr = Console.ReadLine();

                if (char.TryParse(symbolStr, out symbol))
                    break;
                else
                    Console.WriteLine("Symbol please!");
            }

            calculationLine += symbol;
            
            return calculationLine;
        }

        public void GetCalculationLine()
        { Console.WriteLine(calculationLine); }

        public char GetLastSymbol()
        {
            char lastSymbol = calculationLine[calculationLine.Length - 1];
            
            return lastSymbol;
        }

        public string DeleteLastSymbol()
        {
            int index = calculationLine.Length - 1;

            calculationLine = calculationLine.Remove(index);
            
            return calculationLine;
        }
    }
}