using Darkenstone.Buffs;
using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public class HealingPotionMurloc : Ability
    {
        private Character _character;

        public const string ConstructorName = "Healing Potion";
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Heals murloc for 65 health."; } }
        public override ICaster Caster
        {
            get { return _character; }
            set { _character = value as Character; }
        }

        public override int CoolDown { get; protected set; }
        public override int TimeBeforeCastable { get; set; }
        public override int CastTime { get; set; }
        public override int TimeBeforeEffect { get; set; }
        public override int ManaCost { get; set; }
        public override bool Offensive { get { return false; } }
        public override Buff Buff { get; protected set; }

        public HealingPotionMurloc()
        {
            CoolDown = 3;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public HealingPotionMurloc(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalHealing = 65;
            Damaging.DoHealing(_character, finalHealing);
        }
    }
}
