using Darkenstone.Abilities;
using System.Collections.Generic;

namespace Darkenstone.Common
{
    public class Player: Character
    {
        public Player(Stats stats, List<Ability> abilities): base(stats, abilities)
        {
            Mana = stats.MaxMana;
        }

        public void LevelUp(int newLevel, int intGain, int spiritGain, int healthGain, int manaGain)
        {
            Stats.Level = newLevel;
            Stats.Intellect += intGain;
            Stats.Spirit += spiritGain;
            Stats.MaxHealthPoints += healthGain;
            Stats.MaxMana += manaGain;
            ResetResources();
        }
    }
}