using System;
using System.Collections.Generic;

namespace NeedForSpeedIII
{
    class Car
    {
        public Car(int mileage, int fuel)
        {
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string currCar = carsInfo[0];
                int currMileage = int.Parse(carsInfo[1]);
                int currFuel = int.Parse(carsInfo[2]);

                cars.Add(currCar, new Car(currMileage, currFuel));
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                // 25/50 - size

                string cmdType = cmdArgs[0];
                string car = cmdArgs[1];

                if (cmdType == "Drive")
                {
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);

                    if (cars[car].Fuel >= fuel)
                    {
                        cars[car].Mileage += distance;
                        cars[car].Fuel -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (cars[car].Mileage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (cmdType == "Refuel")
                {
                    int fuel = int.Parse(cmdArgs[2]);
                    int currFuel = cars[car].Fuel;

                    cars[car].Fuel += fuel;

                    if (cars[car].Fuel > 75)
                    {
                        cars[car].Fuel = 75;

                        Console.WriteLine($"{car} refueled with {75 - currFuel} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if (cmdType == "Revert")
                {
                    int kilometers = int.Parse(cmdArgs[2]);

                    cars[car].Mileage -= kilometers;

                    if (cars[car].Mileage < 10000)
                    {
                        cars[car].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }
}
