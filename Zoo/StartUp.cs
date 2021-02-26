using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Mammal dog = new Mammal("Sharo");

            Console.WriteLine(dog.Name);
        }
    }
}