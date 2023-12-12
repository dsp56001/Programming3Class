using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSprint10DI.Models
{
    public interface IWeapon
    {
        string Name { get; }
        int Damage {  get; }
    }
}
