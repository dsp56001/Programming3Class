using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSprint10DI.Models
{
    public class CharacterModule : NinjectModule
    {
        public override void Load()
        {
            //Binding
            this.Bind<ICharacter>().To<Samuri>();
            this.Bind<Character>().To<Samuri>();
            this.Bind<IWeapon>().To<Sword>();
            this.Bind<IWeapon>().To<Katana>().WhenInjectedInto<Samuri>();
            this.Bind<IWeapon>().To<Sword>().WhenInjectedInto<Ninja>(); //optional
        }
    }
}
