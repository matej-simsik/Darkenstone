﻿using Darkenstone.Buffs;
using Darkenstone.Common;
using System;

namespace Darkenstone.Abilities
{
    public class SwipeMurloc : Ability
    {
        private Character _character;

        public const string ConstructorName = "Swipe";
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Causes 30 - 45 damage."; } }
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

        public SwipeMurloc()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public SwipeMurloc(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalDamage = Random.Next(30, 46);
            Damaging.DoDamage(damageable, finalDamage);
        }
    }
}
