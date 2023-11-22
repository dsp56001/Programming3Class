using ConsoleAppSprint10DI.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class NinjectTest
    {
        IKernel kernel;

        public NinjectTest()
        {
            kernel = new StandardKernel(new CharacterModule());
        }


        [TestMethod]
        public void TestDefaultWeaponNinja()
        {
            //Arrance 
            ICharacter c;
            //Act
            c = kernel.Get<Ninja>();
            //Assert
            Assert.IsInstanceOfType(c.Weapon, typeof(Sword));
        }

        [TestMethod]
        public void TestDefaultWeaponSamuri()
        {
            //Arrance 
            ICharacter c;
            //Act
            c = kernel.Get<Samuri>();
            //Assert
            Assert.IsInstanceOfType(c.Weapon, typeof(Katana));
        }

        [TestMethod]
        public void TestDefaultICharacterToSamuri()
        {
            //Arrance 
            ICharacter c;
            //Act
            c = kernel.Get<ICharacter>();
            //Assert
            Assert.IsInstanceOfType(c, typeof(Samuri));
        }

        [TestMethod]
        public void TestDefaultIWeaponToSword()
        {
            //Arrance 
            IWeapon w;
            //Act
            w = kernel.Get<IWeapon>();
            //Assert
            Assert.IsInstanceOfType(w, typeof(Sword));
        }
    }
}
