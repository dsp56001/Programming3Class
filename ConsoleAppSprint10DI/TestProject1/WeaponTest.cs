using ConsoleAppSprint10DI.Models;

namespace TestProject1
{
    [TestClass]
    public class WeaponTest
    {
        [TestMethod]
        public void TestDefaultWeaponNinja()
        {
            //Arrance 
            ICharacter c;
            //Act
            c = new Ninja(new Sword());
            //Assert
            Assert.IsInstanceOfType(c.Weapon, typeof(Sword));
        }

        [TestMethod]
        public void TestDefaultWeaponSamuri()
        {
            //Arrance 
            ICharacter c;
            //Act
            c = new Samuri(new Katana());
            //Assert
            Assert.IsInstanceOfType(c.Weapon, typeof(Katana));
        }
    }
}