using Darkenstone.Buffs;
using Darkenstone.Common;
using System;

namespace Darkenstone.Abilities
{
    public class FireShotDragon : Ability
    {
        private Character _character;

        public const string ConstructorName = "Fire Shot"; 
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Causes damage equal to 20 % of " + 
            "caster's health."; } }
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

        public FireShotDragon()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public FireShotDragon(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalDamage = (int)Math.Round(_character.HealthPoints * 0.2, 0);
            Damaging.DoDamage(damageable, finalDamage);
        }
    }
}
