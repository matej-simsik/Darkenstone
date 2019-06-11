using Darkenstone.Buffs;
using Darkenstone.Common;
using System;

namespace Darkenstone.Abilities
{
    public class FirstAid : Ability
    {
        private Character _character;

        public const string ConstructorName = "First Aid";
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Heals the caster for " + 
            MinHeal.ToString() + " - " + MaxHeal.ToString() + "."; } }
        public override ICaster Caster
        {
            get { return _character; }
            set
            {
                _character = value as Character;
                int baseManaCost = 11;
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
        public const int BaseHeal = 20;
        public const decimal HealPerIntellect = 0.8m;
        public const decimal Range = 0.15m;
        public const int ManaCostIncrease = 7;
        public const int HealPerLevel = 20;
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
        public int MinHeal { get { return (int)Math.Round(FinalMeanHeal * (1 - Range), 0); } }
        public int MaxHeal { get { return (int)Math.Round(FinalMeanHeal * (1 + Range), 0); } }


        public FirstAid()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 11;
        }

        public FirstAid(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalHealing = Random.Next(MinHeal, MaxHeal + 1);
            Damaging.DoHealing(_character, finalHealing);
        }
    }
}
