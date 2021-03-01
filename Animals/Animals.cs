﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animals
    {
        
        public string  Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        

        public Animals(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine(string.Empty);
        }
    }
}