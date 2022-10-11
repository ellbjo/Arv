using System;
using System.Collections.Generic;
using System.Text;

namespace Arv.test
{
    public class Reptile : Animals
    {
        
        //Reptile constructor that takes in arguments
        public Reptile(string species, string colour, string sound, int weight, int age) : base(species, colour, sound, weight, age)
        {

        }

        //constructor for default reptiles
        public Reptile()
        {

        }


        //Creates a method that tells us that the animal is a reptile
        public void LaysEgg()
        {
            Console.WriteLine("This animal is a reptile");
        }
        
    }
}
