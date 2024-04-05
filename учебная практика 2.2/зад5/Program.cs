using System;

namespace зад5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine($"person1: {person1.name} {person1.age}");

            Person person2 = new Person("Daria", 18);
            Console.WriteLine($"person2: {person2.name} {person2.age}");
        }
    }

    public class Person
    {
        public string name;

        public int age;

        public Person()
        {
            name = "Undefined";
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        ~Person() { Console.WriteLine($"Object ({name}) deleted!"); }
    }
}