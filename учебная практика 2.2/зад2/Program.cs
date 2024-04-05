using System;
using System.Collections.Generic;

namespace зад2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Train> trains = new List<Train>(); 
 
            Train train1 = new Train("Astrakhan – Volgograd", 41, new DateTime(2024, 9,23,23,15,00)); 
            Train train2 = new Train("Tambov – Moscow", 45, new DateTime(2024, 9,25,12,45,00)); 
            Train train3 = new Train("Moscow – Voronezh", 65, new DateTime(2024, 9,15,15,35,00)); 
            Train train4 = new Train("Moscow – Lipetsk", 70, new DateTime(2024, 9,21,16,5,00)); 
 
            trains.Add(train1); 
            trains.Add(train2); 
            trains.Add(train3); 
            trains.Add(train4); 
 
            FindTrain(trains); 
        }

        static void FindTrain(List<Train> trains) 
        { 
            int number; 
     
            while (true) 
            { 
                Console.Write("Enter the number of train: "); 
                string numberStr = Console.ReadLine(); 
         
                if (int.TryParse(numberStr, out number)) 
                    break; 
                else  
                    Console.WriteLine("Enter the number!"); 
            } 
 
            bool result = false; 
            for (int i = 0; i < trains.Count; i++) 
            { 
                if (trains[i].TrainNumber == number) 
                { 
                    Console.WriteLine( 
                        $"Train: {trains[i].NameOfDestination} №{trains[i].TrainNumber} Date:{trains[i].DepartureTime.ToString("G")}"); 
                    result = true; 
                    break; 
                } 
            } 
     
            if (!result) 
                Console.WriteLine("There is no such train"); 
        } 
    }
    
    public class Train 
    { 
        public string NameOfDestination { get; set; } 
 
        public int TrainNumber { get; set; } 
 
        public DateTime DepartureTime { get; set; } 
 
        public Train(string nameOfDestination, int trainNumber, DateTime departureTime) 
        { 
            NameOfDestination = nameOfDestination; 
            TrainNumber = trainNumber; 
            DepartureTime = departureTime; 
        } 
    }
}