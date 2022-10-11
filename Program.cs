using System;

namespace Arv.test
{
    public class Program
    {
        static void Main(string[] args)
        { 
           //Creates default animals and prints their properties and methods
            Samoyed Lily = new Samoyed();
            Lily.makeSound();
            Lily.samoyedFact();
            Console.WriteLine("Samoyeds are used for " + Lily.use);
            Lily.DirectBirth();
            Console.WriteLine("Samoyeds are " + Lily.characteristic);
      

            Console.WriteLine("");

            Giraff giraff1 = new Giraff();
            giraff1.makeSound();
            Console.WriteLine("This giraffe is " + giraff1.pattern);
            giraff1.ObviousFact();
            giraff1.DirectBirth();
            

            Console.WriteLine("");

            Chihuahua chihuahua1 = new Chihuahua();
            chihuahua1.makeSound();
            Console.WriteLine("Chihuahuas are from " + chihuahua1.origin);
            chihuahua1.chihuahuaFact();
            chihuahua1.DirectBirth();

            Console.WriteLine("");

            Snake snake1 = new Snake();
            snake1.makeSound();
            Console.WriteLine("This animal is " + snake1.speed);
            Console.WriteLine("This snake is " + snake1.age + " years old");
            snake1.LaysEgg();





            


            
                            
           


        }
    }
}
