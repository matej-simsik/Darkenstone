using Darkenstone.Buffs;

namespace Darkenstone.Buffs
{
    public interface IBuffManager
    {
        void AddBuff(Buff buff);
        void RemoveBuff(Buff buff);

        /// <summary>
        /// Calls startTick() method on all active buffs.
        /// </summary>
        /// <seealso cref="Buff.StartTick()"/>
        void StartTick();

        /// <summary>
        /// Calls endTick() method on all active buffs.
        /// </summary>
        /// <seealso cref="Buff.EndTick()"/>
        void EndTick();

        /// <summary>
        /// Reduces duration and delay on all active buffs and removes those with
        /// no remaining duration.
        /// </summary>
        void FinishRound();
    }
}