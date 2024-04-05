using System;

namespace зад1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();

            student = AddStudent(student);

            bool isWork = true;
            while (isWork)
            {
                int command;
                while (true)
                {
                    Console.WriteLine("\n---------------\nChoose the command: 1 - change student, 2 - show student information, 3 - finish the program:");
                    string commandStr = Console.ReadLine();

                    if (int.TryParse(commandStr, out command))
                        break;
                    else 
                        Console.WriteLine("NO!");
                }

                switch (command)
                {
                    case 1:
                    {
                        AddStudent(student);

                        break;
                    }
                    case 2:
                    {
                        PrintInformation(student);

                        break;
                    }
                    case 3:
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

        public static Student AddStudent(Student student)
        {
            Console.Write("Enter the surname of student: ");
            student.Surname = Console.ReadLine();
        
            while(true)
            {
                Console.Write("Enter the date of birth in the format dd/MM/yyyy: ");
                string input = Console.ReadLine();
            
                if (DateTime.TryParse(input, out DateTime date))
                {
                    student.DateOfBirth = date;
                        
                    break;
                }
                else
                    Console.WriteLine("NO!");
            }
        
            while(true)
            {
                Console.Write("Enter the number of group: ");
                string input = Console.ReadLine();
            
                if (int.TryParse(input, out int numberOfGroup))
                {
                    student.GroupNumber = numberOfGroup;
                
                    break;
                }
                else 
                    Console.WriteLine("NO!");
            }
        
            int[] marks = new int[5] {5, 3, 5, 4, 5};
            student.Progress = marks;
            
            return student;
        }

        public static void PrintInformation(Student student)
        {
            Console.WriteLine($"---------------\nStudent: {student.Surname} {student.DateOfBirth.ToString("d")} gr{student.GroupNumber}");
        
            Console.Write("Progress: ");
        
            foreach(var mark in student.Progress)
                Console.Write(mark + " ");
        }
    }
    
    public class Student
    {
        public string Surname { get; set; }
    
        public DateTime DateOfBirth { get; set; }
    
        public int GroupNumber { get; set; }
    
        public int[] Progress = new int[5];
    }
}