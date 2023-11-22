using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppSprint10DI.Models
{
    public class Katana : Weapon
    {
        public Katana() 
        {
            this.name = "Katana";
            this.damage = 4;
        }
    }
}