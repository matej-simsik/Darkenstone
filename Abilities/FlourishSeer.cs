using Darkenstone.Buffs;
using Darkenstone.Common;
using System;

namespace Darkenstone.Abilities
{
    public class FlourishSeer : Ability
    {
        private Character _character;

        public const string ConstructorName = "Flourish";
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Heals seer for 0 - 200 health this round" + 
            " and additional 50 % healing over next 2 rounds."; } }
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

        public FlourishSeer()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 0;
        }

        public FlourishSeer(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            int finalHealing = Random.Next(0, 201);
            Damaging.DoHealing(_character, finalHealing);

            Buff = new ElvenWaterHOTDarkElf((int)Math.Round(finalHealing * 0.25, 0));
            Buff.Target = _character;

            _character.BuffManager.AddBuff(Buff);
        }
    }
}
