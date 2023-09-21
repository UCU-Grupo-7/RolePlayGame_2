namespace RoleplayGame
{
    public class Bow : IWeapons, IPhysicalItem
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