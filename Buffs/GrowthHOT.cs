using Darkenstone.Common;

namespace Darkenstone.Buffs
{
    public class GrowthHOT : Buff
    {
        public override string Name { get { return "Growth HOT"; } }
        public override IDamageable Target { get; set; }
        public override int Duration { get; set; }
        public override bool Debuff { get { return false; } }
        public override int Delay { get; set; }
        public override string Description { get { return "Heals caster over 3 rounds."; } }
        public int Healing { get; set; }

        public GrowthHOT(int healing)
        {
            Duration = 3;
            Delay = 0;
            Healing = healing;
        }

        public GrowthHOT(int healing, IDamageable target)
            : this(healing)
        {
            Target = target;
        }

        public override void StartTick() { Damaging.DoHealing(Target, Healing); }

        public override void EndTick() { }
    }
}
