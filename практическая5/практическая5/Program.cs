using System;
using System.Runtime.Serialization.Json;
using практическая5;

bool isWork = true;

while (isWork)
{
    Console.WriteLine("-----------------\nВыберите команду:\n1 - просмотр типов машин\n2 - добавление типа машины\n3 - просмотр водителей\n4 - добавление водителя\n5 - просмотр категории прав водителей\n6 - добавление категории прав водителю\n7 - добавление категорий прав\n8 - просмотр категорий\n9 - просмотр машин\n10 - добавление машины\n11 - просмотр маршрутов\n12 - добавление маршрута\n13 - просмотр рейсов\n14 - добавление рейса\n15 - закончить программу\n-----------------");
    string command = Console.ReadLine();

    switch (command)
    { 
        //просмотр типов машин
        case "1":
        {
            DatabaseRequests.GetTypeCarQuery();
                    
            break;
        }
        //добавление типа машины
        case "2":
        {
            Console.Write("Введите тип машины: ");
            string name = Console.ReadLine();
                    
            DatabaseRequests.AddTypeCarQuery(name);
                    
            break;
        }
        //просмотр водителей
        case "3":
        {
            DatabaseRequests.GetDriverQuery();
                    
            break;
        }
        //добавление водителя
        case "4":
        {
            Console.Write("Введите имя водителя: ");
            string firstName = Console.ReadLine();
                    
            Console.Write("Введите фамилию водителя: ");
            string lastName = Console.ReadLine();

            DateTime birthdate;
            while (true)
            {
                Console.Write("Введите дату рождения в формате dd/MM/yyyy");
                string dateStr = Console.ReadLine();

                if (DateTime.TryParse(dateStr, out birthdate))
                    break;
                else 
                    Console.WriteLine("Неверно введена дата!");
            }

            DatabaseRequests.AddDriverQuery(firstName, lastName, birthdate);
                    
            break;
        }
        //просмотр категории прав определенного водителя
        case "5":
        {
            int driver;

            while (true)
            {
                Console.Write("Введите ID водителя: ");
                string driverStr = Console.ReadLine();

                if (int.TryParse(driverStr, out driver))
                    break;
                else 
                    Console.WriteLine("Введите число, пожалуйста!");
            }

            DatabaseRequests.GetDriverRightsCategoryQuery(driver);
                    
            break;
        }
        //добавление категории прав водителю
        case "6":
        {
            int driver, rightsCategory;

            while (true)
            {
                Console.Write("Введите ID водителя: ");
                string driverStr = Console.ReadLine();

                if (int.TryParse(driverStr, out driver))
                    break;
                else 
                    Console.WriteLine("Введите число!");
            }

            while (true)
            {
                Console.Write("Введите ID категории прав: ");
                string rightsCategoryStr = Console.ReadLine();

                if (int.TryParse(rightsCategoryStr, out rightsCategory))
                    break;
                else 
                    Console.WriteLine("Введите число!");
            }
            
            DatabaseRequests.AddDriverRightsCategoryQuery(driver, rightsCategory);

            break;
        }
        //добавление категории прав
        case "7":
        {
            Console.Write("Введите категорию прав: ");
            string name = Console.ReadLine();
                    
            DatabaseRequests.AddRightsCategoryQuery(name);
                    
            break;
        }
        //просмотр категорий
        case "8":
        {
            DatabaseRequests.GetRightsCategoryQuery();

            break;
        }
        //просмотр машин
        case "9":
        {
            DatabaseRequests.GetCarsQuery();
                    
            break;
        }
        //добавление машины
        case "10":
        {
            int idTypeCar, numberPassengers;

            while (true)
            {
                Console.Write("Введите ID типа машины: ");
                string idTypeCarStr = Console.ReadLine();

                if (int.TryParse(idTypeCarStr, out idTypeCar))
                    break;
                else 
                    Console.WriteLine("Введите число!");
            }

            Console.Write("Введите название машины: ");
            string name = Console.ReadLine();
                    
            Console.Write("Введите номера автомобиля: ");
            string stateNumber = Console.ReadLine();
            
            while (true)
            {
                Console.Write("Введите количество пассажиров: ");
                string numberPassengersStr = Console.ReadLine();

                if (int.TryParse(numberPassengersStr, out numberPassengers))
                    break;
                else 
                    Console.WriteLine("Введите число!");
            }

            DatabaseRequests.AddCarQuery(idTypeCar, name, stateNumber, numberPassengers);

            break;
        }
        //просмотр маршрутов
        case "11":
        {
            DatabaseRequests.GetItineraryQuery();
                    
            break;
        }
        //добавление маршрута
        case "12":
        {
            Console.Write("Введите название маршрута: ");
            string name = Console.ReadLine();
                    
            DatabaseRequests.AddItineraryQuery(name);
                    
            break;
        }
        //просмотр рейсов
        case "13": 
        {
            DatabaseRequests.GetRouteQuery();
                    
            break;
        }
        //добавление рейса
        case "14":
        {
            int idDriver, idCar, idItinerary, numberPassengers;

            while (true)
            {
                Console.Write("Введите ID водителя: ");
                string idDriverStr = Console.ReadLine();

                if (int.TryParse(idDriverStr, out idDriver))
                    break;
                else
                    Console.WriteLine("Введите число!");
            }

            while (true)
            {
                Console.Write("Введите ID машины: ");
                string idCarStr = Console.ReadLine();
                
                if (int.TryParse(idCarStr, out idCar))
                    break;
                else
                    Console.WriteLine("Введите число!");
            }
                    
            while (true)
            {
                Console.Write("Введите ID маршрута: ");
                string idItineraryStr = Console.ReadLine();

                if (int.TryParse(idItineraryStr, out idItinerary))
                    break;
                else
                    Console.WriteLine("Введите число!");
            }
                    
            while (true)
            {
                Console.Write("Введите количество пассажиров: ");
                string numberPassengersStr = Console.ReadLine();

                if (int.TryParse(numberPassengersStr, out numberPassengers))
                    break;
                else
                    Console.WriteLine("Введите число!");
            }
                    
            DatabaseRequests.AddRouteQuery(idDriver, idCar, idItinerary, numberPassengers);
                    
            break;
        }
        //завершение программы
        case "15":
        {
            isWork = false;
                    
            break;
        }
        default:
        {
            Console.WriteLine("Нет такой команды!");
                    
            break;
        }
    }
}