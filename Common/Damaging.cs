using System;

namespace Darkenstone.Common
{
    public static class Damaging
    {
        /// <summary>
        /// Does damage to damageable. In case damage done exceeds current health,
        /// the health is set to 0.
        /// </summary>
        /// <param name="damageable">Damaged object.</param>
        /// <param name="baseDamage">Amount of base damage done, decreased by
        /// defense coefficient.</param>
        /// <exception cref="ArgumentNullException">In case damaged object is null.
        /// </exception>
        public static void DoDamage(IDamageable damageable, int baseDamage)
        {
            if (damageable == null) throw new ArgumentNullException(
                "There is no object to damage.");
            int damageDone = Convert.ToInt32(
                Math.Round(baseDamage * damageable.DefenseCoefficient, 0));

            damageable.HealthPoints = Math.Max(0, 
                damageable.HealthPoints - damageDone);
        }

        /// <summary>
        /// Heals damageable by healing. Maximum health of healed object is never
        /// exceeded.
        /// </summary>
        /// <param name="damageable">Healed object.</param>
        /// <param name="healing">Amount of healing done.</param>
        /// <exception cref="ArgumentNullException">In case no healed object is null.
        /// </exception>
        /// <exception cref="DeadException">In case targeted object is dead.
        /// </exception>
        public static void DoHealing(IDamageable damageable, int healing)
        {
            if (damageable == null) throw new ArgumentNullException(
                "There is no object to be healed.");
            if (damageable.IsDead) throw new DeadException(
                "Object cannot be healed because it's dead.");
            damageable.HealthPoints = Math.Min(damageable.MaxHealthPoints,
                damageable.HealthPoints + healing);
        }
    }
}