using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kittens : Animals
    {
        private const string DefaultGender = "Femail";

        public Kittens(string name, int age)
            : base(name, age, DefaultGender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
