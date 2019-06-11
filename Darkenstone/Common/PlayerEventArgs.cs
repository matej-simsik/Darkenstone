using System;

namespace Darkenstone.Common
{
    public class PlayerEventArgs: EventArgs
    {
        public Player Player { get; set; }
        public int Position { get; set; }

        public PlayerEventArgs() : base() { }
        public PlayerEventArgs(Player player, int position) : base() 
        {
            Player = player; 
            Position = position; 
        }
    }
}