using Darkenstone.Buffs;
using Darkenstone.Common;
using System;

namespace Darkenstone.Abilities
{
    public class SicknessDarkElf : Ability
    {
        private Character _character;

        public const string ConstructorName = "Sickness"; 
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Causes 60 - 100 damage instantly and " +
            "additional 150 over 5 rounds."; } }
        public override ICaster Caster
        {
            get { return _character; }
            set { _character = value as Character; }
        }

        public override int CoolDown { get; protected set; }
        public override int TimeBeforeCastable { get; set; }
        public override int CastTime { get; set; }
        public override int TimeBeforeEffect { get; set; }
        public override int ManaCost { get; set; }
        public override bool Offensive { get { return true; } }
        public override Buff Buff { get; protected set; }

        public SicknessDarkElf()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public SicknessDarkElf(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            Buff = new SicknessDOTDarkElf(30);
            Buff.Target = damageable;

            int finalDamage = Random.Next(60, 101);
            Damaging.DoDamage(damageable, finalDamage);

            damageable.BuffManager.AddBuff(Buff);
        }
    }
}
