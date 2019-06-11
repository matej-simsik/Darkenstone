using Darkenstone.Abilities;
using Darkenstone.Common;
using System.Collections.Generic;
using System.Linq;

namespace Darkenstone.Game
{
    public class RoundManager: IRoundManager
    {
        public int Round { get; private set; }
        public Player Player { get; private set; }
        public Character Monster { get; private set; }
        public bool IsPlayersTurn { get; private set; }
        public Character Current
        { get { return IsPlayersTurn ? Player : Monster; } }
        public Character Next
        { get { return IsPlayersTurn ? Monster : Player; } }

        public RoundManager(Player player, Character monster)
        {
            Round = 0;
            Player = player;
            Monster = monster;
            IsPlayersTurn = true;
        }

        public Ability FinishRound()
        {
            Ability abilityChosenByMonster = null;

            if (Current == Monster) abilityChosenByMonster = Current.AutochooseAbilities();

            var buffs = (from ability in Current.ChosenAbilities 
                         where ability.Buff != null && !ability.Buff.Debuff 
                         && ability.TimeBeforeEffect == 0
                         select ability.Buff).ToList();

            buffs.ForEach(buff => Current.BuffManager.AddBuff(buff));

            List<Ability> abilitesUsed = new List<Ability>();

            var countsOfAbility = Current.ChosenAbilities.GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

            Current.BuffManager.StartTick();
            Current.ChosenAbilities.ForEach(ability =>
            {
                if (ability.Caster == null)
                    ability.Caster = Current;
            });
            
            foreach (Ability ability in countsOfAbility.Keys)
            {
                if (Current == Player)
                {
                    Player.Mana -= ability.ManaCost * countsOfAbility[ability];
                    ability.ManaCost = 0;
                }

                if (ability.TimeBeforeEffect > 0) ability.TimeBeforeEffect -= 1;
                else
                {
                    if (ability.CoolDown == ability.TimeBeforeCastable)
                        for (int i = 0; i < countsOfAbility[ability]; i++) { ability.Use(Next); }

                    if (ability.TimeBeforeCastable == 0)
                    {
                        abilitesUsed.Add(ability);
                        ability.TimeBeforeCastable = ability.CoolDown;
                        ability.TimeBeforeEffect = ability.CastTime;
                    }
                    else ability.TimeBeforeCastable -= 1;
                }
            }

            Current.BuffManager.EndTick();
            Current.BuffManager.FinishRound();
            Current.ChosenAbilities.RemoveAll(ability => abilitesUsed.Contains(ability));

            if (Current == Player) Player.Mana += Player.Stats.Spirit;

            IsPlayersTurn = !IsPlayersTurn;
            Round += 1;

            return abilityChosenByMonster;
        }
    }
}
