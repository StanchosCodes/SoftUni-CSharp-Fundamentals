using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model, int  weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
       public List<Truck> Trucks { get; set; }
       public List<Car> Cars { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogObject = new Catalogue();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                int lastCommand = int.Parse(cmdArgs[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, lastCommand);
                    catalogObject.Cars.Add(newCar);
                }
                if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, lastCommand);
                    catalogObject.Trucks.Add(newTruck);
                }
            }

            if (catalogObject.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalogObject.Cars.OrderBy(car => car.Brand).ToList();

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogObject.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalogObject.Trucks.OrderBy(truck => truck.Brand).ToList();

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
