using System;
using System.Collections.Generic;

namespace упр2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Worker worker1 = new Worker("Daria", "Frolova", 1200, 12);
            Worker worker2 = new Worker("Diana", "Panteleeva", 12, 1400);
            Worker worker3 = new Worker("Zarina", "Galeeva", 500, 23);
            Worker worker4 = new Worker("Aleksandr", "Kambala", 14, 34);

            List<Worker> workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);
            workers.Add(worker4);

            foreach (var worker in workers)
                Console.WriteLine($"Worker: {worker.GetName()} {worker.GetSurName()}, rate: {worker.GetRate()}, worked days: {worker.GetDays()}, salary: {worker.GetSalary(worker.GetRate(), worker.GetDays())} $");
        }
    }
    
    public class Worker
    {
        private string name;

        private string surname;

        private int rate;

        private int days;

        public int GetSalary(int rate, int days)
    
        { return rate * days; }

        public string GetSurName()
        { return surname; }
    
        public string GetName()
        { return name; }
    
        public int GetRate()
        { return rate; }
    
        public int GetDays()
        { return days; }
        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
    }
}