namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Goblin : Creature
    {
        private const int goblinAttack = 4;
        private const int goblinDefense = 2;
        private const int goblinHealthPoints = 5;
        private const decimal GoblinDamage = 1.5M;
        public Goblin() 
            : base(goblinAttack, goblinDefense, goblinHealthPoints, GoblinDamage )
        {
        }
    }
}
