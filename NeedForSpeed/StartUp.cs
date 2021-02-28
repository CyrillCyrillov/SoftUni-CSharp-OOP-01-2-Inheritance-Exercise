using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar redFerrarri = new SportCar(420, 150);
            FamilyCar silverMazda = new FamilyCar(110, 75);

            redFerrarri.Drive(120);
            silverMazda.Drive(85);

            Console.WriteLine($"Ferrarri -> fule: {redFerrarri.Fuel}");
            Console.WriteLine($"Mazda -> fule: {silverMazda.Fuel}");
        }
    }
}
