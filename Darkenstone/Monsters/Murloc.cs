using Darkenstone.Abilities;
using Darkenstone.Common;
using System.Collections.Generic;
using System.Drawing;

namespace Darkenstone.Monsters
{
    public class Murloc : Character
    {
        public Murloc()
            : base(new Stats("Murloc"), new List<Ability>())
        {
            Stats.Level = 1;
            Stats.Experience = 10;
            Stats.Gold = 15;
            Stats.Intellect = 0;
            Stats.Spirit = 0;
            Stats.MaxHealthPoints = 375;
            Stats.IconColor = Color.DodgerBlue;
            HealthPoints = MaxHealthPoints;
            Stats.MaxMana = 0;
            _abilities = new List<Ability>();
            _abilities.Add(new SwipeMurloc(this));
            _abilities.Add(new HealingPotionMurloc(this));
        }
    }
}
