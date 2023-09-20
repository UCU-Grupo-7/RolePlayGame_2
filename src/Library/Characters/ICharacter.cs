namespace RoleplayGame
{
    public interface ICharacter
    {
        int Health { get; set; }
        string Name{ get; }
        int AttackValue { get; }
        int DefenseValue { get; }

        public void Attack(ICharacter character);
        public void Cure();
    }
}