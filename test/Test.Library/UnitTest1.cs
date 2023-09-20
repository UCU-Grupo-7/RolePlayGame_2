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
            gimli.Cure();
            Assert.That(gimli.Health, Is.EqualTo(100));
        }
        [Test]
        public void Atacar()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book; 

            Dwarf gimli = new Dwarf("Gimli");
            //gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield(); 

            gandalf.Attack(gimli);

            Assert.That(gimli.Health, Is.EqualTo(40));
        }
        [Test]
        public void Test3()
        {
            Assert.Pass();
        }
        
    }

    
}