using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabersPriceTotal = lightsabersPrice * Math.Ceiling(students * 1.1);
            double robesPriceTotal = robesPrice * students;
            double beltsPriceTotal = beltsPrice * (students - (students / 6));

            double totalPrice = lightsabersPriceTotal + robesPriceTotal + beltsPriceTotal;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }
        }
    }
}
