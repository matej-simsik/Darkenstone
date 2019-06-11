using Darkenstone.Common;
using System;

namespace Darkenstone.Buffs
{
    public class DarkenstoneHellDebuffDragon : Buff
    {
        private int _tickCount = 0;
        private Character _character;
        public override string Name { get { return "Darkenstone hell buff"; } }
        public override IDamageable Target { get; set; }
        public override int Duration { get; set; }
        public override bool Debuff { get { return true; } }
        public override int Delay { get; set; }
        public override string Description { get { return "Weakens target."; } }
        public int CurrentHealth { get; set; }

        public DarkenstoneHellDebuffDragon()
        {
            Duration = 3;
            Delay = 0;
        }

        public DarkenstoneHellDebuffDragon(IDamageable target)
            : this()
        {
            Target = target;
            _character = (Character)target;
        }

        public override void StartTick() { }

        public override void EndTick()
        {
            if (_tickCount == 0)
            {
                _tickCount += 1;
                _character.DamageCoefficient -= 0.1m;
                int manaDecrease = (int)(((Character)Target).Mana * 0.1);
                _character.Mana -= Math.Min(manaDecrease, _character.Mana);
            }
            else if (_tickCount == 1) _tickCount += 1;
            else
            {
                ((Character)Target).DamageCoefficient += 0.1m;
            }
        }
    }
}
