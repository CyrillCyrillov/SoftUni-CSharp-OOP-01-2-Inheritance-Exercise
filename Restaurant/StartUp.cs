using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Cake redVelvet = new Cake("Red Velvet");
            Console.WriteLine($"{redVelvet.Name} - {redVelvet.Price} - {redVelvet.Grams} - {redVelvet.Calories}");
        }
    }
}