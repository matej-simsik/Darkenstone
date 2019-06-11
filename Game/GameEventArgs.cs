using Darkenstone.Common;
using System;

namespace Darkenstone.Game
{
    public class GameEventArgs : EventArgs
    {
        public Player Player { get; set; }
        public Character Monster { get; set; }
        public bool PlayerWon { get; set; }

        public GameEventArgs() : base() { }
        public GameEventArgs(Player player, Character monster) : this()
        {
            Player = player;
            Monster = monster;
        }
        public GameEventArgs(Player player, Character monster, bool playerWon) : this(player, monster)
        {
            PlayerWon = playerWon;
        }
    }
}
