using Darkenstone.Abilities;
using Darkenstone.Buffs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace Darkenstone.Common
{
    public class Character: ICaster, IDamageable
    {
        protected List<Ability> _abilities;
        private int _mana;
        private static Random random = new Random();

        public Stats Stats { get; protected set; }
        public int MaxHealthPoints { get { return Stats.MaxHealthPoints; } }
        public int MaxMana { get { return Stats.MaxMana; } }
        public ReadOnlyCollection<Ability> Abilities
        { get { return new ReadOnlyCollection<Ability>(_abilities); } }
        public int HealthPoints { get; set; }
        public int Mana
        {
            get { return _mana; }
            set { _mana = Math.Max(Math.Min(value, MaxMana), 0); }
        }
        public decimal DefenseCoefficient { get; set; }
        public decimal DamageCoefficient { get; set; }
        public IBuffManager BuffManager { get; protected set; }
        public List<Ability> ChosenAbilities { get; set; }
        public bool IsDead { get { return HealthPoints <= 0; } }

        public Character(Stats stats, List<Ability> abilities)
        {
            Stats = stats;
            _abilities = abilities;
            _abilities.ForEach(ability => { ability.Caster = this; });
            BuffManager = new BuffManager();
            ChosenAbilities = new List<Ability>();
            HealthPoints = stats.MaxHealthPoints;
            DefenseCoefficient = 1;
            DamageCoefficient = 1;
        }

        public void ResetResources()
        {
            HealthPoints = MaxHealthPoints;
            Mana = MaxMana;
            BuffManager = new BuffManager();
            ChosenAbilities = new List<Ability>();
            DefenseCoefficient = 1;
            DamageCoefficient = 1;
        }

        public virtual Ability AutochooseAbilities()
        {
            if (Abilities == null) return null;

            var usableAbilities = (from ability in Abilities
                                   where ability.TimeBeforeCastable == ability.CoolDown
                                   select ability).ToList();

            int index = random.Next(usableAbilities.Count);
            ChosenAbilities.Add(usableAbilities[index]);
            return usableAbilities[index];
        }
    }
}