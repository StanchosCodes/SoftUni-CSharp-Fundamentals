using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceForBox
        {
            get
            {
                return this.Quantity * this.Item.Price;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> allBoxes = new List<Box>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();

                int seialNumber = int.Parse(cmdArgs[0]);
                string itemName = cmdArgs[1];
                int quantity = int.Parse(cmdArgs[2]);
                decimal price = decimal.Parse(cmdArgs[3]);

                Box currentBox = new Box()
                {
                    SerialNumber = seialNumber,

                    Item = new Item()
                    {
                        Name = itemName,
                        Price = price
                    },

                    Quantity = quantity
                };

                allBoxes.Add(currentBox);
            }

            List<Box> orderedBoxes = allBoxes.OrderByDescending(boxes => boxes.PriceForBox).ToList(); // Подрежда листа от обекти по цената на обекта във възходящ ред; може да е по каквото му зададем; OrderBy само, е за подреждане в низходящ ред

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }
}
