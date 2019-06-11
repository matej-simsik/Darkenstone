using Darkenstone.Common;

namespace Darkenstone.Buffs
{
    public class FireBreathDOTDragon : Buff
    {
        public override string Name { get { return "Fire breath DOT"; } }
        public override IDamageable Target { get; set; }
        public override int Duration { get; set; }

        public override bool Debuff { get { return true; } }
        public override int Delay { get; set; }
        public override string Description { get { return "Causes damage for up to 3 rounds."; } }
        public int Damage { get; set; }

        public FireBreathDOTDragon(int damage)
        {
            Duration = 3;
            Delay = 0;
            Damage = damage;
        }

        public FireBreathDOTDragon(int damage, IDamageable target)
            : this(damage)
        {
            Target = target;
        }

        public override void StartTick() { }

        public override void EndTick() { Damaging.DoDamage(Target, Damage); }
    }
}
