using Darkenstone.Abilities;
using Darkenstone.Common;
using System.Collections.Generic;
using System.Drawing;

namespace Darkenstone.Monsters
{
    public class Goblin : Character
    {
        public Goblin()
            : base(new Stats("Goblin"), new List<Ability>())
        {
            Stats.Level = 2;
            Stats.Experience = 15;
            Stats.Gold = 25;
            Stats.Intellect = 0;
            Stats.Spirit = 0;
            Stats.MaxHealthPoints = 400;
            Stats.IconColor = Color.DarkGreen;
            HealthPoints = MaxHealthPoints;
            Stats.MaxMana = 0;
            _abilities = new List<Ability>();
            _abilities.Add(new StingGoblin(this));
            _abilities.Add(new GunShotGoblin(this));
        }
    }
}
