using Darkenstone.Buffs;
using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public class Growth : Ability
    {
        private Character _character;

        public const string ConstructorName = "Growth";
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Heals the caster for " + 
            ((int)FinalMeanHeal).ToString() + " every round for 3 rounds."; } }
        public override ICaster Caster
        {
            get { return _character; }
            set
            {
                _character = value as Character;
                int baseManaCost = 14;
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
        public const int BaseHeal = 14;
        public const decimal HealPerIntellect = 0.3m;
        public const decimal Range = 0.1m;
        public const int ManaCostIncrease = 7;
        public const int HealPerLevel = 10;
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


        public Growth()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 14;
        }

        public Growth(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalHealing = (int)FinalMeanHeal;

            Buff = new GrowthHOT(finalHealing);
            Buff.Target = _character;

            _character.BuffManager.AddBuff(Buff);
        }
    }
}
