using System;

namespace зад3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            Nums.num1 = Nums.AddNum();

            Console.WriteLine("Enter the first number:");
            Nums.num2 = Nums.AddNum();

            bool isWork = true;
            while (isWork)
            {
                Console.WriteLine(
                    "\n---------------\nChoose the command: 1 - print numbers, 2 - change numbers, 3 - sum of numbers, 4 - max of numbers, 5 - finish the program\n---------------");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                    {
                        Nums.PrintNums();

                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("Enter the first number: ");
                        Nums.num1 = Nums.ChangeNum(Nums.num1);
                        
                        Console.WriteLine("Enter the second number: ");
                        Nums.num2 = Nums.ChangeNum(Nums.num2);

                        break;
                    }
                    case "3":
                    {
                        Console.Write($"{Nums.num1} + {Nums.num2} = {Nums.Sum(Nums.num1, Nums.num2)}");
                        
                        break;
                    }
                    case "4":
                    {
                        Console.Write($"Max: {Nums.Max(Nums.num1, Nums.num2)}");

                        break;
                    }
                    case "5":
                    {
                        isWork = false;

                        break;
                    }
                    default:
                    {
                        Console.Write("There is no such command!");
                        
                        break;
                    }
                }
            }
        }
    }
    
    public class Nums
    {
        public static int num1 { get; set; }
        public static int num2 { get; set; }
        public static int AddNum()
        {
            int num; 
            
            while (true)
            {
                string numStr = Console.ReadLine();
                
                if (int.TryParse(numStr, out num))
                    break;
                else
                    Console.WriteLine("Number please!");
            }
            
            return num;
        }
        public static void PrintNums()    
        { Console.Write($"num1 = {num1}, num2 = {num2}"); }
        public static int ChangeNum(int num)
        {        
            while (true)
            {
                string numStr = Console.ReadLine();
                
                if (int.TryParse(numStr, out num))
                    break;
                else
                    Console.WriteLine("Number please!");
            }
            
            return num;
        }
        public static int Sum(int num1, int num2)   
        { return num1 + num2; }
        public static int Max(int num1, int num2)
        { return num1 > num2 ? num1 : num2; }
    }
}