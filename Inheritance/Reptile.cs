using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {

        public Reptile() 
        { 
            IsScaly= true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 0;
        }

        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }

        public bool CanGrowTail { get; set; }
    }
}
