using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppSprint10DI.Models
{
    public class Sword : Weapon
    {
        public Sword()
        {
            this.name = "Sword";
            this.damage = 3;
        }
    }
}