using Darkenstone.Common;
using System;

namespace Darkenstone.Buffs
{
    public abstract class Buff: IEquatable<Buff>
    {
        public abstract string Name { get; }
        public abstract IDamageable Target { get; set; }
        public abstract int Duration { get; set; } 
        public abstract bool Debuff { get; }
        public abstract int Delay { get; set; }
        public abstract string Description { get; }

        /// <summary>
        /// Executes the part of the buff that takes place before abilities are used.
        /// </summary>
        public abstract void StartTick();

        /// <summary>
        /// Executed the part of the buff that takes place after abilities are used.
        /// </summary>
        public abstract void EndTick();

        public bool Equals(Buff obj)
        {
            if (obj == null) return false;

            return obj.Name == Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Buff o)) return false;

            return o.Name == Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}