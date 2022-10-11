using System;
using System.Collections.Generic;
using System.Text;

namespace Arv.test
{

    public class Chihuahua : Dog
    {
        //Specific property for chihuahuas
        public string origin;

        //Constructor for new chihuahuas
        public Chihuahua(string species, string colour, string sound, int weight, int age, string characteristic, string origin) : base(species, colour, sound, weight, age, characteristic)
        {
            this.origin = "Mexico";
        }

        //Default chihuahua
        public Chihuahua()
        {
            this.species = "Chihuahua";
            this.colour = "Light brown";
            this.weight = 6;
            this.age = 5;
            this.characteristic = "yappy";
            this.origin = "Mexico";

        }

        //Overridden method that prints out costum sound instead of the one in "Dog"-class
        public override void makeSound()
        {
            Console.WriteLine("Wiff-Wiff");
        }

        //Prints unique method
        public void chihuahuaFact()
        {
            Console.WriteLine("Chihuahuas can have manes");
        }

    }
}
