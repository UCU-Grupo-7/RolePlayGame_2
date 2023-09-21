namespace RoleplayGame
{
    public class Helmet : IDefenseItem, IPhysicalItem
    {
        public int DefenseValue
        {
            get
            {
                return 55;
            }
        }
    }
}