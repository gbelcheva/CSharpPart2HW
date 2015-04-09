namespace ArmyOfCreatures.Logic.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;

    public class AddAttackWhenSkip : Specialty
    {
        private const int MinAttackToAdd = 1;
        private const int MaxAttackToAdd = 10;
        private readonly int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            if (attackToAdd < MinAttackToAdd || MaxAttackToAdd < attackToAdd)
            {
                throw new ArgumentOutOfRangeException(string.Format("AttackToAdd", "The attack to add cannot be {0}. Valid range is ({1},{2}].", attackToAdd, MinAttackToAdd, MaxAttackToAdd));
            }
            this.attackToAdd = attackToAdd;

            this.attackToAdd = attackToAdd;
        }
        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.attackToAdd);
        }
    }
}
