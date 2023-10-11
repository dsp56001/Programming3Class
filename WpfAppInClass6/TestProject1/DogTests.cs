using WpfApp3.Models;

namespace TestProject1
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void DogConstructorDefaults()
        {
            //Arrange
            Dog d;
            string defaultName = "fido";
            int defaultAge = 1;
            int defaultWeight = 1;
            string defaultBarkSound = "woof!";
            //Act
            d = new Dog();

            //Assert
            Assert.IsInstanceOfType(d, typeof(Dog));
            Assert.AreEqual(defaultName, d.Name);
            Assert.AreEqual(defaultAge, d.Age);
            Assert.AreEqual(defaultWeight, d.Weight);
            Assert.AreEqual(defaultBarkSound, d.BarkSound);
            
        }

        [TestMethod]
        public void TestDogBark()
        {
            //Arrage
            Dog d = new Dog();
            string expectedBark;
            //Act
            expectedBark = "woof!";
            //Assert
            Assert.AreEqual(expectedBark, d.Bark());
        }

        [TestMethod]
        public void TestDogInhertance()
        {
            //Arrage
            Dog d = new Dog();

            //Act

            //Assert
            Assert.IsInstanceOfType(d, typeof(IAboutable));
            Assert.IsInstanceOfType(d, typeof(IEat));
            Assert.IsInstanceOfType(d, typeof(IBarkable));
        }

        [TestMethod]
        public void TestDogAbout()
        {
            //Arrage
            Dog d = new Dog();
            string expectedAbout;
            //Act
            expectedAbout = "Hello my name is fido";
            //Assert
            Assert.AreEqual(expectedAbout, d.About());
        }

    }
}