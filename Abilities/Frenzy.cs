using Darkenstone.Buffs;
using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public class Frenzy : Ability
    {
        private Character _character;

        public const string ConstructorName = "Frenzy";
        public override string Name { get { return ConstructorName; } }
        public override string Description { get { return "Increases your total damage next turn " +
            "by 10 %."; } }
        public override ICaster Caster
        {
            get { return _character; }
            set
            {
                _character = value as Character;
                int baseManaCost = 0;
                int level = 0;
                if (Caster is Character character) level = character.Stats.Level;
                ManaCost = baseManaCost + level * ManaCostIncrease;
            }
        }

        public override int CoolDown { get; protected set; }
        public override int TimeBeforeCastable { get; set; }
        public override int CastTime { get; set; }
        public override int TimeBeforeEffect { get; set; }
        public override int ManaCost { get; set; }
        public override bool Offensive { get { return false; } }
        public override Buff Buff { get; protected set; }
        public const int ManaCostIncrease = 0;
       
        public Frenzy()
        {
            CoolDown = 0;
            TimeBeforeCastable = CoolDown;

            CastTime = 0;
            TimeBeforeEffect = CastTime;
            ManaCost = 4;
        }

        public Frenzy(ICaster caster)
            : this()
        {
            Caster = caster;
        }

        public override void Use(IDamageable damageable)
        {
            Buff = new FrenzyBuff(_character);
            Buff.Target = _character;

            _character.BuffManager.AddBuff(Buff);
        }
    }
}
