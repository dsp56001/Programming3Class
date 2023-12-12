using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace ConsoleAppSprint10DI.Models
{
    public class UnityBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ICharacter, Samuri>();
            container.RegisterType<Character, Samuri>();
            container.RegisterType<IWeapon, Sword>();

            container.RegisterType<Samuri>(new InjectionConstructor(new Katana()));
            container.RegisterType<Ninja>(new InjectionConstructor(new Sword()));

            

            
        }
    }
}
