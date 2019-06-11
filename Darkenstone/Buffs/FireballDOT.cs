using Darkenstone.Common;

namespace Darkenstone.Buffs
{
    public class FireballDOT : Buff
    {
        public override string Name { get { return "Fireball DOT"; } }
        public override IDamageable Target { get; set; }
        public override int Duration { get; set; }
        public override bool Debuff { get { return true; } }
        public override int Delay { get; set; }
        public override string Description { get { return "Causes severe burns."; } }
        public int Damage { get; set; }

        public FireballDOT(int damage) 
        {
            Duration = 3;
            Delay = 0;
            Damage = damage;
        }

        public FireballDOT(int damage, IDamageable target): this(damage)
        {
            Target = target;
        }

        public override void StartTick() { }

        public override void EndTick() { Damaging.DoDamage(Target, Damage); }
    }
}
