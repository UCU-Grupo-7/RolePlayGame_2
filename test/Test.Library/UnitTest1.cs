using NUnit.Framework;
using System.Collections.Generic;

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
            gimli.DefenseItem = new List<IDefenseItem>() {new Helmet(), new Shield()} ;
            gimli.AttackItem = new Axe();
            

            int gimliStartHealth = gimli.Health;  // vida con la que arranca gimli
            
            gandalf.Attack(gimli);

            //Assert.That(gimli.Health, Is.EqualTo(40));
            Assert.That(gimli.Health, Is.EqualTo(gimliStartHealth -= gandalf.AttackValue - gimli.DefenseValue));
        }
        [Test]
        public void Test3()
        {
            Assert.Pass();
        }
        
    }

    
}