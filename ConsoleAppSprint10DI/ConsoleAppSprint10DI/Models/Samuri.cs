using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSprint10DI.Models
{
    public class Samuri : Character
    {
        public Samuri(IWeapon weapon) : base (weapon)
        {
            this.name = "samuri";
        }
        
    }
}
