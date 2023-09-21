namespace RoleplayGame
{
    public class Bow : IAttackItem, IPhysicalItem
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
    }
}