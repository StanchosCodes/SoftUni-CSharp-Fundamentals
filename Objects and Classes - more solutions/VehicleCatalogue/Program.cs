using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            return $"Type: {(this.Type == "car" ? "Car" : "Truck")}\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.Horsepower}";
        }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Vehicle>();
            this.Trucks = new List<Vehicle>();
        }
        public List<Vehicle> Cars { get; set; }
        public List<Vehicle> Trucks { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogueObject = new Catalogue();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split();

                string type = cmdArgs[0];
                string model = cmdArgs[1];
                string color = cmdArgs[2];
                int horsepower = int.Parse(cmdArgs[3]);

                Vehicle newVehicle = new Vehicle(type, model, color, horsepower);

                if (type == "car")
                {
                    catalogueObject.Cars.Add(newVehicle);
                }
                else
                {
                    catalogueObject.Trucks.Add(newVehicle);
                }
            }

            string searchedModel;
            while ((searchedModel = Console.ReadLine()) != "Close the Catalogue")
            {
                if (catalogueObject.Cars.Any(c => c.Model == searchedModel))
                {
                    Vehicle car = catalogueObject.Cars.Find(c => c.Model == searchedModel);
                    Console.WriteLine(car);
                }
                else if (catalogueObject.Trucks.Any(t => t.Model == searchedModel))
                {
                    Vehicle truck = catalogueObject.Trucks.Find(t => t.Model == searchedModel);
                    Console.WriteLine(truck);
                }
            }

            double carHorsepower = 0;
            double truckHorsepower = 0;

            if (catalogueObject.Cars.Count > 0)
            {
                carHorsepower = catalogueObject.Cars.Average(a => a.Horsepower);
                Console.WriteLine($"Cars have average horsepower of: {carHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (catalogueObject.Trucks.Count > 0)
            {
                truckHorsepower = catalogueObject.Trucks.Average(a => a.Horsepower);
                Console.WriteLine($"Trucks have average horsepower of: {truckHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }    
        }
    }
}
