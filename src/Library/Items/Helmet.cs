namespace RoleplayGame
{
    public class Helmet : IDefenses, IPhysicalItem
    {
        public int DefenseValue
        {
            get
            {
                return 18;
            }
        }
    }
}