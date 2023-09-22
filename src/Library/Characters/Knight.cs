using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight : ICharacter
    {
        private int health = 100;

        public Knight(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        //public Sword Sword { get; set; }

        //public Shield Shield { get; set; }

        //public Armor Armor { get; set; }
        public IAttackItem AttackItem{ get; set; }

        public List<IDefenseItem> DefenseItem { get; set; }

        public int AttackValue
        {
            get
            {
                return this.AttackItem.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                int defense = 0;
                foreach (IDefenseItem item in DefenseItem)
                {
                    defense += item.DefenseValue;
                    
                } 

                return defense;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        /* public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        } */
        public void Attack(ICharacter character)
        {
            if (character.DefenseValue < this.AttackValue)
            {
                character.Health -= this.AttackValue - character.DefenseValue;
            }
        }
        public void Cure()
        {
            this.Health = 100;
        }
    }
}