using Darkenstone.Common;

namespace Darkenstone.Buffs
{
    public class FrenzyBuff : Buff
    {
        private bool _initialized = false;
        public override string Name { get { return "Frenzy"; } }
        public override IDamageable Target { get; set; }
        public override int Duration { get; set; }
        public override bool Debuff { get { return false; } }
        public override int Delay { get; set; }
        public override string Description { get { return "Increases damage for 1 round."; } }
        public int Healing { get; set; }

        public FrenzyBuff()
        {
            Duration = 2;
            Delay = 0;
        }

        public FrenzyBuff(Character target)
            : this()
        {
            Target = target;
        }

        public override void StartTick() { }

        public override void EndTick() 
        {
            if (_initialized) ((Character)Target).DamageCoefficient -= 0.1m;
            else
            {
                _initialized = true;
                ((Character)Target).DamageCoefficient += 0.1m;
            }
        }
    }
}
