namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    public class CyclopsKing : Creature
    {
        private const int CyclopsKingAttack = 17;
        private const int CyclopsKingDefense = 13;
        private const int CyclopsKingHealthPoints = 70;
        private const decimal CyclopsKingDamage = 18M;
        public CyclopsKing()
            : base(CyclopsKingAttack, CyclopsKingDefense, CyclopsKingHealthPoints, CyclopsKingDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}