using Darkenstone.Abilities;
using Darkenstone.Common;

namespace Darkenstone.Game
{
    public interface IRoundManager
    {
        int Round { get; }

        /// <summary>
        /// Returns the character, whose turn it is to play.
        /// </summary>
        Character Current { get; }

        /// <summary>
        /// Returns the character, whose turn it will be after current character 
        /// finishes his round.
        /// </summary>
        Character Next { get; }

        ///<summary>
        ///Ensures all abilities and buffs of current character playing are 
        ///correctly used and changes current character.
        ///</summary>
        ///<returns>Ability chosen by monster. If it was player's round, returns null.</returns>
        Ability FinishRound();
    }
}
