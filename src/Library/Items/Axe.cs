namespace RoleplayGame
{
    public class Axe : IAttackItem, IPhysicalItem
    {
        public int AttackValue 
        {
            get
            {
                return 25;
            } 
        }
    }
}