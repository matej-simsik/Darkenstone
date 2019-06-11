using Darkenstone.Common;

namespace Darkenstone.Buffs
{
    public class SicknessDOTDarkElf : Buff
    {
        public override string Name { get { return "Sickness DOT"; } }
        public override IDamageable Target { get; set; }
        public override int Duration { get; set; }
        public override bool Debuff { get { return true; } }
        public override int Delay { get; set; }
        public override string Description { get { return "Causes damage over 5 rounds."; } }
        public int Damage { get; set; }

        public SicknessDOTDarkElf(int damage)
        {
            Duration = 5;
            Delay = 0;
            Damage = damage;
        }

        public SicknessDOTDarkElf(int damage, IDamageable target)
            : this(damage)
        {
            Target = target;
        }

        public override void StartTick() { }

        public override void EndTick() { Damaging.DoDamage(Target, Damage); }
    }
}
