namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    public class AncientBehemoth : Creature
    {
        private const int AncientBehemothAttack = 19;
        private const int AncientBehemothDefense = 19;
        private const int AncientBehemothHealthPoints = 300;
        private const decimal AncientBehemothDamage = 40M;
        public AncientBehemoth()
            : base(AncientBehemothAttack, AncientBehemothDefense, AncientBehemothHealthPoints,  AncientBehemothDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}