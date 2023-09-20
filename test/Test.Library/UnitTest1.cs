using NUnit.Framework;

namespace RoleplayGame
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Curar()
        {
            Dwarf gimli = new Dwarf("Gimli");
            /* gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield(); */
            gilmi.Cure();
            Assert.AreEqual(100, Dwarf.health);
        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            Assert.Pass();
        }
        
    }

    
}