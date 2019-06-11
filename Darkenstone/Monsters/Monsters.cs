using Darkenstone.Abilities;
using Darkenstone.Common;
using System.Collections.Generic;
using System.Drawing;

namespace Darkenstone.Monsters
{

    public class DarkenstoneDragon : Character
    {
        public DarkenstoneDragon()
            : base(new Stats("Darkenstone Dragon"), new List<Ability>())
        {
            Stats.Level = 5;
            Stats.Experience = 0;
            Stats.Gold = 200;
            Stats.Intellect = 0;
            Stats.Spirit = 0;
            Stats.MaxHealthPoints = 3000;
            Stats.IconColor = Color.Firebrick;
            HealthPoints = MaxHealthPoints;
            Stats.MaxMana = 0;
            _abilities = new List<Ability>();

            _abilities.Add(new FireBreathDragon(this));
            _abilities.Add(new FireShotDragon(this)); 
            _abilities.Add(new DarkenstoneHellDragon(this));
        }
    }
}
