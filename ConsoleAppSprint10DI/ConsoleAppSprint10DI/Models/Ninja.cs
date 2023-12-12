using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSprint10DI.Models
{
    public class Ninja : Character
    {
        public Ninja(IWeapon weapon) :base(weapon) 
        {
            this.name = "ninja";
        }
       
    }
}
