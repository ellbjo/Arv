using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Arv.test
{
    public class Dog : Mammal
    {

        //Unique property for the "Dog" class and the classes that inherites from it
        public string characteristic;

        //Constructor
        public Dog(string species, string colour, string sound, int weight, int age, string characteristic) : base(species, colour, sound, weight, age)
        {
            this.characteristic = "Friendly";
        }

        //Default dog
        public Dog()
        {
            this.species = "Dog";
            this.colour = "Brown";
            this.sound = "Woff-woff";
            this.weight = 25;
            this.age = 5;
            this.characteristic = "friendly";
        }

        //Unique method, also acceccible for classes inheriting from the "Dog" class
        public virtual void Waggingtail()
        {
            Console.WriteLine("The dog is wagging its tail");
        }

    
    }
}
