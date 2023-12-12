using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSprint10DI.Models
{
    public interface ICharacter
    {
        string Name { get; set; }
        IWeapon Weapon { get; set; }

        
    }
}
