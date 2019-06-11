using Darkenstone.Buffs;
using Darkenstone.Common;
using System;

namespace Darkenstone.Abilities
{
    public abstract class Ability //: IEquatable<Ability>
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract ICaster Caster { get; set; }
        public abstract int CoolDown { get; protected set; }
        public abstract int TimeBeforeCastable { get; set; }
        public abstract int CastTime { get; set; }
        public abstract int TimeBeforeEffect { get; set; }
        public abstract int ManaCost { get; set; }
        public abstract bool Offensive { get; }
        public abstract Buff Buff { get; protected set; }
        public static Random Random = new Random();

        /// <summary>
        /// Causes ability to take effect.
        /// </summary>
        /// <param name="damageable">In case the ability is targeted, it may
        /// require target object.</param>
        public abstract void Use(IDamageable damageable);
    }
}