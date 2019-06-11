using Darkenstone.Abilities;
using Darkenstone.Common;
using System;

namespace Darkenstone.Game
{
    public interface IGameManager
    {
        Character Monster { get; }
        Player Player { get; }
        event EventHandler<GameEventArgs> GameOver;

        void StartGame();
        void EndGame();
        /// <summary>
        /// Finishes the round and causes the game to end in case of proper 
        /// conditions.
        /// </summary>
        /// <returns>Ability chosen by monster. If no ability was chosen or it was player's round,
        /// returns null.</returns>
        Ability FinishRound();        
    }
}
