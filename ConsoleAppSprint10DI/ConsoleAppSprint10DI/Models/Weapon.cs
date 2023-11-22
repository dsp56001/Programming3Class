using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSprint10DI.Models
{
    public abstract class Weapon : IWeapon
    {
        protected string name;

        public string Name => this.name;

        protected int damage;

        public int Damage { get => this.damage; protected set => this.damage = value; }

        public Weapon()
        {
            this.name = "not a weapon";
            this.damage = 1;
        }
    }

}
