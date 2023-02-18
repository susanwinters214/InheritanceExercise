using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly= true;
            myBird.WillMigrate= true;
            myBird.BeakLength= 3.5;

            var lizard = new Reptile()
            {
                IsColdBlooded= true,
                IsScaly= true,
                Habitat = "swamp",
                CanGrowTail= true,
            };

            // Collection of Animals:

            var myAnimals = new Animal[2]
            {
                myBird, lizard
            };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"It has: {animal.IsAlive} legs");
                Console.WriteLine($"It lives by: {animal.LandSeaAir}");
                Console.WriteLine( " ");
            }

        }
    }
}
