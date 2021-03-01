using System;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string animaType = Console.ReadLine();

                if (animaType == "Beast!") break;

                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(data.Length < 3 || int.Parse(data[1]) <= 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                
                // name = data[0]
                // age = data[1]
                // gender = data[2]

                switch (animaType)
                {
                    case "Dog":
                        Dog nextDog = new Dog(data[0], int.Parse(data[1]), data[2]);
                        Console.Write(animaType);
                        Console.WriteLine($"{nextDog.Name} {nextDog.Age} {nextDog.Gender}");
                        nextDog.ProduceSound();
                        break;

                    case "Cat":
                        Cat nextCat = new Cat(data[0], int.Parse(data[1]), data[2]);
                        Console.Write(animaType);
                        Console.WriteLine($"{nextCat.Name} {nextCat.Age} {nextCat.Gender}");
                        nextCat.ProduceSound();
                        break;

                    case "Frog":
                        Frog nextFrog = new Frog(data[0], int.Parse(data[1]), data[2]);
                        Console.Write(animaType);
                        Console.WriteLine($"{nextFrog.Name} {nextFrog.Age} {nextFrog.Gender}");
                        nextFrog.ProduceSound();
                        break;

                    case "Kittens":
                        Kittens nextKittie = new Kittens(data[0], int.Parse(data[1]));
                        Console.Write(animaType);
                        Console.WriteLine($"{nextKittie.Name} {nextKittie.Age} {nextKittie.Gender}");
                        nextKittie.ProduceSound();
                        break;

                    case "Tomcat":
                        Tomcat nextTomcat = new Tomcat(data[0], int.Parse(data[1]));
                        Console.Write(animaType);
                        Console.WriteLine($"{nextTomcat.Name} {nextTomcat.Age} {nextTomcat.Gender}");
                        nextTomcat.ProduceSound();
                        break;

                    default:
                        break;
                }
            }
            
        }
    }
}
