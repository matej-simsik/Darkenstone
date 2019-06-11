using Darkenstone.Common;

namespace Darkenstone.Buffs
{
    public class ElvenWaterHOTDarkElf : Buff
    {
        public override string Name { get { return "Elven water HOT"; } }
        public override IDamageable Target { get; set; }
        public override int Duration { get; set; }
        public override bool Debuff { get { return false; } }
        public override int Delay { get; set; }
        public override string Description { get { return "Heals caster over 5 rounds."; } }
        public int Healing { get; set; }

        public ElvenWaterHOTDarkElf(int healing)
        {
            Duration = 5;
            Delay = 0;
            Healing = healing;
        }

        public ElvenWaterHOTDarkElf(int healing, IDamageable target)
            : this(healing)
        {
            Target = target;
        }

        public override void StartTick() { Damaging.DoHealing(Target, Healing); }

        public override void EndTick() { }
    }
}
