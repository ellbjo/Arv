using System;
using System.Collections.Generic;
using System.Text;

namespace Arv.test
{
    public class Mammal : Animals
    {

        //Constructor that takes in arguments to create new mammals
        public Mammal(string species, string colour, string sound, int weight, int age) : base(species, colour, sound, weight, age)
        {
            
        }

        //Constructor for the default mammals
        public Mammal()
        {

        }



        // Creates a method that tells us that the animal is a mammal
        public void DirectBirth()
        {
            Console.WriteLine("This animal is a mammal");
        }
    }
}
