using Darkenstone.Buffs;
using Darkenstone.Common;
using System;

namespace Darkenstone.Abilities
{
    public class FireBreathDragon : Ability
    {
        private Character _character;

        public const string ConstructorName = "Fire Breath"; 
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Causes 300 damage to enemy and " + 
            "additional burns for 100 - 500 damage over next 3 rounds."; } }
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

        public FireBreathDragon()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public FireBreathDragon(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalDamage = 300;
            Damaging.DoDamage(damageable, finalDamage);

            int finalDOT = Random.Next(100, 501);
            Buff = new FireBreathDOTDragon((int)((decimal)(finalDOT) / 3), damageable);
            Buff.Target = damageable;

            damageable.BuffManager.AddBuff(Buff);
        }
    }
}
