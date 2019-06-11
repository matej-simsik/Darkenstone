using Darkenstone.Buffs;
using System.Collections.Generic;

namespace Darkenstone.Buffs
{
    public class BuffManager: IBuffManager
    {
        private List<Buff> _activeBuffs;

        public BuffManager()
        {
            _activeBuffs = new List<Buff>();
        }

        public void AddBuff(Buff buff)
        {
            _activeBuffs.Add(buff);
        }

        public void RemoveBuff(Buff buff)
        {
            _activeBuffs.Remove(buff);
        }

        public void StartTick()
        {
            _activeBuffs.ForEach(buff => { if (buff.Delay == 0) buff.StartTick(); });
        }

        public void EndTick()
        {
            _activeBuffs.ForEach(buff => { if (buff.Delay == 0) buff.EndTick(); });
        }

        public void FinishRound()
        {            
            ReduceDuration();
            ReduceDelay();
        }

        public void ReduceDuration()
        {
            _activeBuffs.ForEach(buff => { if (buff.Delay == 0) buff.Duration -= 1; });
            _activeBuffs.RemoveAll(buff => buff.Duration == 0);
        }

        public void ReduceDelay()
        {
            _activeBuffs.ForEach(buff => { if (buff.Delay > 0) buff.Delay -= 1; });
        }
    }
}