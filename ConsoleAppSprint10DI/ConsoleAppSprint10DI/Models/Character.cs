using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSprint10DI.Models
{
    public class Character : ICharacter
    {
        protected string name;
        protected IWeapon weapon;
        
        public string Name { get => name; set => name = value; }
        public IWeapon Weapon { get => weapon ; set => weapon = value; }

        public Character(IWeapon weapon) 
        {
            this.name = "not a name";
            this.weapon = weapon;
        }
    }
}
