using Darkenstone.Buffs;
using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public class FireBurns : Ability
    {
        private Character _character;

        public const string ConstructorName = "Fire Burns";
        public override string Name { get { return ConstructorName; } }
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

        public override string Description 
        { get { return "Causes " + ((int)FinalMeanDamage).ToString() + " damage every round over next 3 rounds."; } }
        public override int CoolDown { get; protected set; }
        public override int TimeBeforeCastable { get; set; }
        public override int CastTime { get; set; }
        public override int TimeBeforeEffect { get; set; }
        public override int ManaCost { get; set; } 
        public override bool Offensive { get { return true; } }
        public override Buff Buff { get; protected set; }
        public const int BaseDamage = 6;
        public const decimal DamagePerIntellect = 0.1m;
        public const decimal Range = 0.1m;
        public const int ManaCostIncrease = 7;
        public const int DamagePerLevel = 7;
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

        public FireBurns()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 1;
            TimeBeforeEffect = CastTime;
            ManaCost = 10;
        }

        public FireBurns(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalDamage = (int)FinalMeanDamage;

            Damaging.DoDamage(damageable, finalDamage);

            Buff = new FireBurnsDOT(finalDamage);
            Buff.Target = damageable;
            damageable.BuffManager.AddBuff(Buff);
        }
    }
}
