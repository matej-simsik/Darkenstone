using Darkenstone.Abilities;
using Darkenstone.Common;
using Darkenstone.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class GamePlayControl : UserControl
    {
        private MainForm _mainForm;
        private IGameManager _gameManager;
        private Player _player;
        private Character _monster;
        private List<AbilityCard> _abilityCards;

        private Thread _updatePlayerHealthThread;
        private Thread _updatePlayerManaThread;
        private Thread _updateMonsterHealthThread;

        private delegate void ChangeResourceBar(SmoothProgressBar.SmoothProgressBar resourceBar,
            int value);
        private delegate void InfoChange(string text);
        private delegate void ButtonEnable(bool enable);
        private delegate void UpdateControl();
        private delegate void UpdateAbility(Ability abilityChosen);

        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; } }

        public IGameManager GameManager
        {
            get { return _gameManager; }
            set 
            {
                _gameManager = value;
                Player = _gameManager.Player;
                Monster = _gameManager.Monster;
                abilityCardMonster.IsVacant = true;
                playerHealthBar.Value = _gameManager.Player.HealthPoints;
                playerManaBar.Value = _gameManager.Player.Mana;
                monsterHealthBar.Value = _gameManager.Monster.HealthPoints;
                buttonFinishRound.Enabled = true;
            }
        }

        public Player Player
        {
            get { return _player; }
            set
            {
                _player = value;
                abilityContainer1.IsVacant = true;
                abilityContainer2.IsVacant = true;
                abilityContainer3.IsVacant = true;
                playerHealthBar.Maximum = _player.MaxHealthPoints;
                playerManaBar.Maximum = _player.Stats.MaxMana;
                playerIcon.Character = _player;
                playerIcon.IsSelectable = false;
                UpdateAbilities();
            }
        }

        public Character Monster
        {
            get { return _monster; }
            set
            {
                _monster = value;
                monsterIcon.Character = _monster;
                monsterIcon.IsSelectable = false;
                monsterHealthBar.Maximum = _monster.MaxHealthPoints;
            }
        }

        public int PlayerPosition { get; set; }

        public GamePlayControl()
        {
            InitializeComponent();

            AbilityCard[] cards = new AbilityCard[] { 
                abilityCard1, abilityCard2, abilityCard3, abilityCard4,
                abilityCard5, abilityCard6, abilityCard7, abilityCard8,
                abilityCard9, abilityCard10
            };
            _abilityCards = new List<AbilityCard>(cards);

            abilityCardMonster.IsVacant = true;
        }

        public int CountSelectedCards()
        {
            int selected = 0;

            selected += abilityContainer1.AbilityCard.IsVacant ? 0 : 1;
            selected += abilityContainer2.AbilityCard.IsVacant ? 0 : 1;
            selected += abilityContainer3.AbilityCard.IsVacant ? 0 : 1;

            return selected;
        }

        private void ButtonFinishRound_Click(object sender, EventArgs e)
        {
            int totalManaCost = 0;
            if (!abilityContainer1.IsVacant) totalManaCost +=
                abilityContainer1.Ability.ManaCost;
            if (!abilityContainer2.IsVacant) totalManaCost +=
                abilityContainer2.Ability.ManaCost;
            if (!abilityContainer3.IsVacant) totalManaCost +=
                abilityContainer3.Ability.ManaCost;

            if (totalManaCost > Player.Mana)
            {
                MessageWindow messageWindow = new MessageWindow("You don't have enough mana!");
                messageWindow.ShowDialog();
                return;
            }

            int selected = CountSelectedCards();

            if (selected < 3)
            {
                MessageWindow messageWindow = new MessageWindow("You only selected " +
                    selected.ToString() + " abilities. Do you wish to continue?");
                var result = messageWindow.ShowDialog();

                if (result != DialogResult.OK)
                {
                    return;
                }                
            }

            buttonFinishRound.Enabled = false;
            abilityCardMonster.IsVacant = true;

            if (!abilityContainer1.IsVacant)
                Player.ChosenAbilities.Add(abilityContainer1.Ability);
            if (!abilityContainer2.IsVacant)
                Player.ChosenAbilities.Add(abilityContainer2.Ability);
            if (!abilityContainer3.IsVacant)
                Player.ChosenAbilities.Add(abilityContainer3.Ability);

            GameManager.FinishRound();
            DoUpdate();

            if (Player.HealthPoints == 0 || Monster.HealthPoints == 0)
            {
                Thread endGameThread = new Thread(EndGame);
                endGameThread.Start();
            }
            else
            {
                Ability abilityChosen = GameManager.FinishRound();
                Thread opponentAnimationThread = new Thread(() =>
                    OpponentAnimation(0, abilityChosen));
                opponentAnimationThread.Start();

                if (Player.HealthPoints == 0 || Monster.HealthPoints == 0)
                {
                    Thread endGameThread = new Thread(EndGame);
                    endGameThread.Start();
                }
            }
        }

        private void DoUpdate()
        {
            abilityContainer1.Ability = null;
            abilityContainer2.Ability = null;
            abilityContainer3.Ability = null;
            UpdateAbilities();

            _updatePlayerHealthThread = new Thread(() => AnimateProgressChange(playerHealthBar,
                    _player.HealthPoints));          
            _updatePlayerManaThread = new Thread(() => AnimateProgressChange(playerManaBar,
                _player.Mana));            
            _updateMonsterHealthThread = new Thread(() => AnimateProgressChange(monsterHealthBar,
                    _monster.HealthPoints));

            _updatePlayerHealthThread.Start();
            _updatePlayerManaThread.Start();
            _updateMonsterHealthThread.Start();
        }

        private void UpdateAbilityChosen(Ability abilityChosen)
        {
            abilityCardMonster.Ability = abilityChosen;
            abilityCardMonster.IsSelectable = false;
        }

        private void EndGame()
        {
            UpdateControl endGameControl = new UpdateControl(EndGameUpdate);

            while (ResourceBarProgressFinished() != true)
            {
                Thread.Sleep(500);
            }

            Invoke(endGameControl);
        }

        private void EndGameUpdate()
        {
            GameManager.EndGame();
        }

        private void OpponentAnimation(int waitTime, Ability abilityChosen)
        {
            InfoChange infoChange = new InfoChange(LabelInfoChange);            
            UpdateControl updateControl = new UpdateControl(DoUpdate);
            UpdateAbility updateAbility = new UpdateAbility(UpdateAbilityChosen);

            int dots = 0;

            while (ResourceBarProgressFinished() != true)
            {
                string dotString = "";
                for (int i = 0; i < 3; i++) dotString += (i < dots) ? "." : " ";
                Invoke(infoChange, new object[] { "Waiting for opponent " + dotString});
                dots = (dots + 1) % 4;
                Thread.Sleep(500);
            }

            Invoke(infoChange, new object[] { "" });
            Invoke(updateControl);
            Invoke(updateAbility, new object[] { abilityChosen });
            Thread waitForEnablingThread = new Thread(ButtonFinishRoundWaitForEnabling);
            waitForEnablingThread.Start();
        }

        private void ButtonFinishRoundWaitForEnabling()
        {
            ButtonEnable buttonEnable = new ButtonEnable(ButtonFinishRoundEnable);

            while (ResourceBarProgressFinished() != true)
            {
                Thread.Sleep(500);
            }

            Invoke(buttonEnable, new object[] { true });
        }

        private void ButtonFinishRoundEnable(bool enable)
        {
            buttonFinishRound.Enabled = enable;
        }

        private bool ResourceBarProgressFinished()
        {
            return !(_updateMonsterHealthThread.IsAlive ||
                _updatePlayerHealthThread.IsAlive ||
                _updatePlayerManaThread.IsAlive);
        }

        private void LabelInfoChange(string text)
        {
            labelInfo.Text = text;
        }

        private void AnimateProgressChange(SmoothProgressBar.SmoothProgressBar resourceBar, 
            int newValue)
        {
            lock (resourceBar)
            {
                int currentValue = resourceBar.Value;
                ChangeResourceBar changeResourceBar = new ChangeResourceBar(ResourceBarChange);
                int holdUp = (int)((20m / resourceBar.Maximum) * 300);

                if (currentValue >= newValue)
                {
                    while (currentValue != newValue)
                    {
                        currentValue -= 1;
                        Invoke(changeResourceBar, new object[] { resourceBar, currentValue });                        
                        Thread.Sleep(holdUp);
                    }
                }
                else
                {
                    while (currentValue != newValue)
                    {
                        currentValue += 1;
                        Invoke(changeResourceBar, new object[] { resourceBar, currentValue });                        
                        Thread.Sleep(20);
                    }
                }
            }
        }

        private void ResourceBarChange(SmoothProgressBar.SmoothProgressBar resourceBar, 
            int value)
        {
            resourceBar.Value = value;
        }

        private void UpdateAbilities()
        {
            for (int i = 0; i < Player.Abilities.Count; i++)
            {
                var abilityNames = Player.ChosenAbilities.Select(ability => ability.Name).ToList();

                if (!abilityNames.Contains(Player.Abilities[i].Name) ||
                    Player.Abilities[i].CoolDown == 0)
                    _abilityCards[i].Ability = AbilityConstructor.Construct(
                        Player.Abilities[i].Name, Player);
                else
                    _abilityCards[i].IsVacant = true;
            }

            for (int i = Player.Abilities.Count; i < 10; i++)
            {
                _abilityCards[i].IsVacant = true;
            }
        }

        private void ButtonEndGame_Click(object sender, EventArgs e)
        {
            MainForm.ShowPreviousControl();
        }

        private void MouseEnters(object sender, EventArgs e)
        {
            if (sender is SmoothProgressBar.SmoothProgressBar progressBar)
            {
                var text = progressBar.Value.ToString() + "/" + progressBar.Maximum.ToString();

                toolTipResource.SetToolTip(progressBar, text);
                toolTipResource.Active = true;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            toolTipResource.Active = false;
        }
    }
}
