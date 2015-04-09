namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DoubleDamage : Specialty
    {
        private const int MinNumberOfRounds = 0;
        private const int MaxNumberOfRounds = 10;
        private int numberOfRounds;
        public DoubleDamage(int numberOfRounds)
        {
            if (numberOfRounds <= MinNumberOfRounds || MaxNumberOfRounds < numberOfRounds)
            {
                throw new ArgumentOutOfRangeException(string.Format("Number of rounds", "The number of rounds cannot be {0}. Valid range is ({1},{2}].", numberOfRounds, MinNumberOfRounds, MaxNumberOfRounds));
            }
            this.numberOfRounds = numberOfRounds;
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender, decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if (this.numberOfRounds <= 0)
            {
                return currentDamage;
            }
            this.numberOfRounds--;
            return currentDamage * 2M;
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.numberOfRounds);
        }
    }
}
