using Darkenstone.Abilities;
using Darkenstone.Common;
using System;

namespace Darkenstone.Game
{
    public class GameManager: IGameManager
    {
        public Character Monster { get; private set; }
        public Player Player { get; private set; }
        public IRoundManager RoundManager { get; private set; }
        public event EventHandler<GameEventArgs> GameOver;

        public GameManager(Player player, Character monster)
        {
            Player = player;
            Monster = monster;
            RoundManager = new RoundManager(Player, Monster);
        }
        
        public void StartGame() { throw new NotImplementedException(); }

        public void EndGame() 
        {
            bool playerWon = false;

            if (Monster.HealthPoints == 0)
            {
                int expGain = Monster.Stats.Experience;
                int exp = Player.Stats.Experience;
                Player.Stats.Gold += Monster.Stats.Gold;

                if (exp < 20 && exp + expGain >= 20) Player.LevelUp(2, 5, 5, 50, 25);
                if (exp < 60 && exp + expGain >= 60) Player.LevelUp(3, 10, 10, 150, 50);
                if (exp < 160 && exp + expGain >= 160) Player.LevelUp(4, 15, 15, 250, 75);
                if (exp < 360 && exp + expGain >= 360) Player.LevelUp(5, 25, 25, 400, 150);

                Player.Stats.Experience += expGain;
                playerWon = true;
            }

            GameOver?.Invoke(this, new GameEventArgs(Player, Monster, playerWon));
        }

        public Ability FinishRound() 
        { 
            Ability chosenAbility = RoundManager.FinishRound();
            return chosenAbility;
        }
    }
}
