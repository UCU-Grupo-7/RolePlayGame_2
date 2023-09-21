namespace RoleplayGame
{
    public class Shield : IDefenseItem, IPhysicalItem
    {
        public int DefenseValue
        {
            get
            {
                return 60;
            }
        }
    }
}