﻿using Darkenstone.Buffs;
using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public class StingGoblin : Ability
    {
        private Character _character;

        public const string ConstructorName = "Sting"; 
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Causes 80 damage over 2 rounds."; } }
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

        public StingGoblin()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public StingGoblin(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            Buff = new StingDOTGoblin(40);
            Buff.Target = damageable;

            damageable.BuffManager.AddBuff(Buff);
        }
    }
}
