using System;

namespace зад4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool isWork = true;
            
            while (isWork)
            {
                Console.WriteLine("1 - leave the counter as default (counter = 0), 2 - set the value");
                string command = Console.ReadLine();

                if (command == "2")
                {
                    while (true)
                    {
                        int value;
                        Console.Write("Enter the value: ");

                        string valueStr = Console.ReadLine();

                        if (int.TryParse(valueStr, out value))
                        {
                            Counter.counter = value;

                            break;
                        }
                        else
                            Console.WriteLine("Number please!");
                    }

                    isWork = false;
                }
                else if (command == "1")
                    isWork = false;
                else 
                    Console.WriteLine("There is no such command!!");
            }

            isWork = true;
            
            while (isWork)
            {   
                Console.WriteLine("Choose the command: \"+\" - increase, \"-\" - decrease, 0 - print counter, 9 - finish the program");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "+":
                    {
                        Counter.Increase();
                        
                        break;
                    }
                    case "-":
                    {
                        Counter.Decrease();
                        
                        break;
                    }
                    case "0":
                    {
                        Console.WriteLine($"counter = {Counter.counter}");
                        
                        break;
                    }
                    case "9":
                    {
                        isWork = false;
                        
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("There is no such command");
                        
                        break;
                    }
                }
            }
        }
    }
    
    public class Counter
    {    
        public static int counter = 0;
        
        public static int Increase()
        {
            counter++;
            
            return counter;
        }

        public static int Decrease()
        {
            counter--;
            
            return counter;
        }
    }
}