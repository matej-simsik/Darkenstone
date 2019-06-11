using Darkenstone.Buffs;
using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public class Meditation : Ability
    {
        private Character _character;

        public const string ConstructorName = "Meditation";
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Regenerates " + ((int)FinalMeanHeal).ToString() + 
            " mana to the caster."; } }
        public override ICaster Caster
        {
            get { return _character; }
            set
            {
                _character = value as Character;
                int baseManaCost = 0;
                int level = 0;
                if (Caster is Character character) level = character.Stats.Level;
                ManaCost = baseManaCost + level * ManaCostIncrease;
            }
        }

        public override int CoolDown { get; protected set; }
        public override int TimeBeforeCastable { get; set; }
        public override int CastTime { get; set; }
        public override int TimeBeforeEffect { get; set; }
        public override int ManaCost { get; set; }
        public override bool Offensive { get { return false; } }
        public override Buff Buff { get; protected set; }
        public const int BaseHeal = 2;
        public const decimal HealPerIntellect = 0.05m;
        public const decimal Range = 0m;
        public const int ManaCostIncrease = 0;
        public const int HealPerLevel = 1;
        public decimal FinalMeanHeal
        {
            get
            {
                decimal finalMeanHeal = BaseHeal;
                if (Caster is Character character)
                {
                    finalMeanHeal += HealPerLevel * character.Stats.Level;
                    finalMeanHeal += HealPerIntellect * character.Stats.Intellect;
                }

                return finalMeanHeal;
            }
        }

        public Meditation()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public Meditation(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalHealing = (int)FinalMeanHeal;
            _character.Mana += finalHealing;
        }
    }
}
