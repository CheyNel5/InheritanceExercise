using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           var myBird = new Bird();
            myBird.WingColor = "red";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 3.8;

            var lizard = new reptile()
            {
                IsColdBlooded = true,
                IsScaley = true,
                IsAlive = true,
                Habitat = "swamp",
                CanRegenerateTail = true,
            };

            var myAnimals = new Animal[] { myBird, lizard };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
        
            }
        }
    }
}
