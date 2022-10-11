using System;
using System.Collections.Generic;
using System.Text;

namespace Arv.test
{
    public class Giraff : Mammal
    {
        //Implements the property solely for giraffes
        public string pattern;

        //Constructor for new giraffes
        public Giraff(string species, string colour, string sound, int weight, int age, string pattern) : base(species, colour, sound, weight, age)
        {
            this.pattern = pattern;
        }

        //Creates the default guitar
        public Giraff()
        {
            this.species = "Giraff";
            this.colour = "Yellow";
            this.sound = "Neeee-iiigh";
            this.weight = 1000;
            this.pattern = "spotty";
    
        }

        //Prints a obvious fact about giraffes, a specific method for the class
        public void ObviousFact()
        {
            Console.WriteLine("This animal has a long neck");
        }

        public override void makeSound()
        {
            Console.WriteLine(sound);
        }
    }
}
