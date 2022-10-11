using System;
using System.Collections.Generic;
using System.Text;

namespace Arv.test
{
    
    public class Samoyed : Dog
    {
        //Property specific for samoyeds

        public string use;
        public Samoyed()
        {
            this.use = "sledding";
            this.characteristic = "loyal";
        }

        public Samoyed(string species, string colour, string sound, int weight, int age, string characteristic, string use) : base(species, colour, sound, weight, age, characteristic)
        {
            this.use = "Sledding";
        }

        //Overridden required method
        public override void makeSound()
        {
            Console.WriteLine("RUFF-RUFF");
        }

        //Unique method
        public void samoyedFact()
        {
            Console.WriteLine("Samoyed likes to dig");
        }
    }
}
