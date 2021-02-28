using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Animals
    {
        private const string DefaultGender = "Mail";

        public Tomcat(string name, int age)
            : base(name, age, DefaultGender)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
