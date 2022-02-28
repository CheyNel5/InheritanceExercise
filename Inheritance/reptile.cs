using System;
namespace Inheritance
{
    public class reptile : Animal
    {
        public reptile()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 0;
        }

        public bool IsColdBlooded { get; set; }
        public bool IsScaley {get; set ;}
        public string Habitat { get; set; }
        public bool CanRegenerateTail { get; set; }
    }
}
