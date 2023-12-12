using ConsoleAppSprint10DI.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace TestProject1
{
    [TestClass]
    public class UnityContainerTests
    {
        // Declare a Unity Container
        IUnityContainer unityContainer;

        public UnityContainerTests()
        {
            //set up unity container
            unityContainer = new UnityContainer();
            UnityBootstrap.RegisterTypes(unityContainer);
        }

        [TestMethod]
        public void TestDefaultWeaponNinja()
        {
            //Arrance 
            ICharacter c;
            //Act
            c = unityContainer.Resolve<Ninja>();
            //Assert
            Assert.IsInstanceOfType(c.Weapon, typeof(Sword));
        }

        

        [TestMethod]
        public void TestDefaultWeaponCharacter()
        {
            //Arrance 
            ICharacter c;
            //Act
            c = unityContainer.Resolve<Character>();
            //Assert
            Assert.IsInstanceOfType(c, typeof(Samuri));
        }

    }


}

