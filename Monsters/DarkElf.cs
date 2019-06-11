using Darkenstone.Abilities;
using Darkenstone.Common;
using System.Collections.Generic;
using System.Drawing;

namespace Darkenstone.Monsters
{
    public class DarkElf : Character
    {
        public DarkElf()
            : base(new Stats("Dark Elf"), new List<Ability>())
        {
            Stats.Level = 3;
            Stats.Experience = 25;
            Stats.Gold = 40;
            Stats.Intellect = 0;
            Stats.Spirit = 0;
            Stats.MaxHealthPoints = 500;
            Stats.IconColor = Color.MidnightBlue;
            HealthPoints = MaxHealthPoints;
            Stats.MaxMana = 0;
            _abilities = new List<Ability>();
            _abilities.Add(new DepressionDarkElf(this));
            _abilities.Add(new SicknessDarkElf(this));
            _abilities.Add(new ElvenWaterDarkElf(this));
        }
    }
}
