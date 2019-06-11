using Darkenstone.Buffs;
using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public class ElvenWaterDarkElf : Ability
    {
        private Character _character;

        public const string ConstructorName = "Elven water"; 
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Heals elf for 30 health each round " +
            "for next 5 rounds."; } }
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

        public ElvenWaterDarkElf()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public ElvenWaterDarkElf(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            Buff = new ElvenWaterHOTDarkElf(30);
            Buff.Target = _character;

            _character.BuffManager.AddBuff(Buff);
        }
    }
}
