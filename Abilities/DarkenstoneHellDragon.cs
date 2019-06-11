﻿using Darkenstone.Buffs;
using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public class DarkenstoneHellDragon : Ability
    {
        private Character _character;

        public const string ConstructorName = "Darkenstone Hell";
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Weakens enemy target, reducing it's mana " +
            "and damage by 10 % for 2 rounds."; } }
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
        public override bool Offensive { get { return false; } }
        public override Buff Buff { get; protected set; }

        public DarkenstoneHellDragon()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public DarkenstoneHellDragon(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            Buff = new DarkenstoneHellDebuffDragon(damageable);

            damageable.BuffManager.AddBuff(Buff);
        }
    }
}
