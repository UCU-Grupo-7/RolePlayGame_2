namespace RoleplayGame
{
    public class Staff : IWeapons, IDefenses, IPhysicalItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}