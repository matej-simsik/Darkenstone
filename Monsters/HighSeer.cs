using Darkenstone.Abilities;
using Darkenstone.Common;
using System.Collections.Generic;
using System.Drawing;

namespace Darkenstone.Monsters
{
    public class HighSeer : Character
    {
        public HighSeer()
            : base(new Stats("High Seer"), new List<Ability>())
        {
            Stats.Level = 4;
            Stats.Experience = 40;
            Stats.Gold = 60;
            Stats.Intellect = 0;
            Stats.Spirit = 0;
            Stats.MaxHealthPoints = 1000;
            Stats.IconColor = Color.DarkMagenta;
            HealthPoints = MaxHealthPoints;
            Stats.MaxMana = 0;
            _abilities = new List<Ability>();
            _abilities.Add(new LightningBoltSeer(this));
            _abilities.Add(new FlourishSeer(this));
            _abilities.Add(new ManaDrainSeer(this));
        }
    }
}
