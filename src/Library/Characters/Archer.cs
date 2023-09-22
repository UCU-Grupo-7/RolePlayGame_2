using System.Collections.Generic;

namespace RoleplayGame
{
    public class Archer : ICharacter
    {
        private int health = 100;
        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
        
        public List<IAttackItem> AttackItem { get; set; }
        //public bow bow { get; set; }

        public IDefenseItem DefenseItem { get; set; }
        //public Helmet Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                int attack = 0;
                foreach (IAttackItem item in AttackItem)
                {
                    attack += item.AttackValue;
                    
                } 

                return attack;
            }
        }

        public int DefenseValue
        {
            get
            {
                return DefenseItem.DefenseValue;
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

/*         public void ReceiveAttack(int power)
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