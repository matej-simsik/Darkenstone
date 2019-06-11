using Darkenstone.Buffs;
using Darkenstone.Common;
using System;

namespace Darkenstone.Abilities
{
    public class Fireshot : Ability
    {
        private Character _character;

        public const string ConstructorName = "Fireshot";
        public override string Name { get { return ConstructorName; } }
        public override ICaster Caster
        {
            get { return _character; }
            set
            {
                _character = value as Character;
                int baseManaCost = 3;
                int level = 0;
                if (Caster is Character character) level = character.Stats.Level;
                ManaCost = baseManaCost + level * ManaCostIncrease;
            }
        }

        public override string Description 
        { get { return "Causes " + MinDamage.ToString() + " - " + MaxDamage.ToString() + " damage."; } }
        public override int CoolDown { get; protected set; }
        public override int TimeBeforeCastable { get; set; }
        public override int CastTime { get; set; }
        public override int TimeBeforeEffect { get; set; }
        public override int ManaCost { get; set; } 
        public override bool Offensive { get { return true; } }
        public override Buff Buff { get; protected set; }
        public const int BaseDamage = 7;
        public const decimal DamagePerIntellect = 0.1m;
        public const decimal Range = 0.15m;
        public const int ManaCostIncrease = 2;
        public const int DamagePerLevel = 4;
        public decimal FinalMeanDamage
        {
            get 
            {
                decimal finalMeanDamage = BaseDamage;
                if (Caster is Character character)
                {
                    finalMeanDamage += DamagePerLevel * character.Stats.Level;
                    finalMeanDamage += DamagePerIntellect * character.Stats.Intellect;
                }

                return finalMeanDamage * (decimal)Caster.DamageCoefficient;
            }
        }
        public int MinDamage { get { return (int)Math.Round(FinalMeanDamage * (1 - Range), 0); } }
        public int MaxDamage { get { return (int)Math.Round(FinalMeanDamage * (1 + Range), 0); } }

        public Fireshot()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 2;
            TimeBeforeEffect = CastTime;
            ManaCost = 5;
        }

        public Fireshot(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalDamage = Random.Next(MinDamage, MaxDamage + 1);

            Damaging.DoDamage(damageable, finalDamage);
        }
    }
}
