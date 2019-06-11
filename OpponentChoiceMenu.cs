using Darkenstone.Abilities;
using Darkenstone.Common;
using Darkenstone.Game;
using Darkenstone.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class OpponentChoiceMenu : UserControl
    {
        private MainForm _mainForm;
        private AddList<Character> _monsters;
        private AddList<Player> _players;
        private List<CharacterIcon> _playerIcons;
        private List<CharacterIcon> _monsterIcons;

        public event EventHandler<PlayerEventArgs> PlayerAdded;
        public event EventHandler<PlayerEventArgs> PlayerRemoved;
        public event EventHandler<GameEventArgs> GameStarted;
        public event EventHandler<PlayerEventArgs> PlayerUpdated;

        public AddList<Player> Players { get { return _players; } }

        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; } }
        public int IndexOfChosenPlayer { get { return SelectedIcon(_playerIcons); } }

        public OpponentChoiceMenu()
        {
            InitializeComponent();
            InitializeMonsters();
            InitializePlayers();           

            SetHighLevelsLocked(0);
        }

        private void InitializePlayers()
        {
            _playerIcons = new CharacterIcon[] { playerIcon1, playerIcon2, 
                playerIcon3, playerIcon4, playerIcon5 }.ToList();

            _players = new AddList<Player>();
            _players.OnAdd += new EventHandler(playerAdded);
            _players.OnRemove += new EventHandler(playerRemoved);

            foreach (CharacterIcon playerIcon in _playerIcons)
            {
                playerIcon.OnSelection += new EventHandler(PlayerIconSelected);
                playerIcon.OnDeselection += new EventHandler(PlayerIconDeselected);
            }            
        }

        private void InitializeMonsters()
        {
            _monsterIcons = new CharacterIcon[] { characterIcon1, characterIcon2, 
                characterIcon3, characterIcon4, characterIcon5 }.ToList();
            _monsters = new AddList<Character>();

            Character monster1 = new Murloc();
            Character monster2 = new Goblin();
            Character monster3 = new DarkElf();
            Character monster4 = new HighSeer();
            Character monster5 = new DarkenstoneDragon();

            _monsters.Add(monster1);
            _monsters.Add(monster2);
            _monsters.Add(monster3);
            _monsters.Add(monster4);
            _monsters.Add(monster5);

            for (int i = 0; i < 5; i++)
            {
                _monsterIcons[i].Character = _monsters[i];
            }

            foreach (CharacterIcon monsterIcon in _monsterIcons)
            {
                monsterIcon.OnSelection += new EventHandler(MonsterIconSelected);
                monsterIcon.OnDeselection += new EventHandler(MonsterIconDeselected);
            }
        }

        public void RefreshControl()
        {
            SetSelectedToFalse(_playerIcons, null);
            SetSelectedToFalse(_monsterIcons, null);
            SetHighLevelsLocked(0);
        }

        public void RefreshPlayer(int index)
        {
            _playerIcons[index].Character = _players[index];
        }

        public bool doesCharacterNameExist(string characterName)
        {
            foreach (CharacterIcon charIcon in _playerIcons)
            {
                if (charIcon.CharacterName == characterName) return true;
            }
            return false;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MainForm.ShowPreviousControl();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCharacterForm addCharacter = new AddCharacterForm(this);
            var result = addCharacter.ShowDialog();

            if (result == DialogResult.OK)
            {
                Ability[] abilityArray = new Ability[] { new Fireshot(), new Fireball(),
                    new Fireblast(), new FireBurns(), new Pyromaniac(), new FirstAid(),
                    new Rejuvenation(), new Growth(), new Meditation(), new Frenzy() };

                List<Ability> abilities = new List<Ability>(abilityArray);

                Player newPlayer = new Player(new Stats(addCharacter.CharacterName), 
                    abilities);
                newPlayer.Stats.IconColor = addCharacter.IconColor;
                _players.Add(newPlayer);

                int countPlayers = _players.Count;
                if (PlayerAdded != null) PlayerAdded(this, 
                    new PlayerEventArgs(newPlayer, countPlayers - 1));                
            }
        }

        private int SelectedIcon(List<CharacterIcon> icons)
        {
            for (int i = 0; i < 5; i++)
            {
                if (icons[i].IsSelected) return i;
            }
            return -1;
        }

        private void playerAdded(object sender, EventArgs e)
        {
            updatePlayers();

            if (_players.Count == 5) buttonAdd.Enabled = false;
        }
    
        private void playerRemoved(object sender, EventArgs e)
        {
            updatePlayers();

            SetHighLevelsLocked(0);
            buttonAdd.Enabled = true;
            if (_players.Count == 0) buttonDelete.Enabled = false;   
        }

        private void updatePlayers()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _playerIcons[i].Character = _players[i];
                _playerIcons[i].Visible = true;
            }

            for (int i = _players.Count; i < 5; i++)
            {
                _playerIcons[i].Character = null;
                _playerIcons[i].Visible = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageWindow messageWindow = new MessageWindow(
                "Do you really want to delete this character?");
            var result = messageWindow.ShowDialog();

            if (result == DialogResult.OK)
            {
                int selected = SelectedIcon(_playerIcons);

                Player playerToRemove = (Player)(_playerIcons[selected].Character);
                _players.Remove(playerToRemove);
                if (PlayerRemoved != null)
                    PlayerRemoved(this, new PlayerEventArgs(playerToRemove, selected));                         
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int selectedPlayer = SelectedIcon(_playerIcons);
            int selectedMonster = SelectedIcon(_monsterIcons);

            Player player = _players[selectedPlayer];
            Character monster = _monsters[selectedMonster];

            player.ResetResources();
            monster.ResetResources();

            if (GameStarted != null) GameStarted(this, new GameEventArgs(player, monster));
            MainForm.ShowNextControl();
        }

        private void SetSelectedToFalse(List<CharacterIcon> icons, CharacterIcon exceptThisIcon)
        {
            foreach (CharacterIcon icon in icons)
            {
                if (icon != exceptThisIcon) icon.IsSelected = false;                    
            }
        }

        private bool OneCharacterSelected(List<CharacterIcon> icons)
        {
            int selected = 0;

            foreach (CharacterIcon icon in icons)
            {
                if (icon.IsSelected) selected += 1;
            }

            return selected == 1;
        }

        private void SetHighLevelsLocked(int level)
        {
            for (int i = 0; i < 5; i++)
            {
                if (_monsters[i].Stats.Level > level) _monsterIcons[i].IsLocked = true;
                else
                {
                    _monsterIcons[i].IsLocked = false;
                    _monsterIcons[i].Character = _monsters[i];                    
                }
            }
        }

        private void PlayerIconDeselected(object sender, EventArgs e)
        {
            SetHighLevelsLocked(0);
            buttonReward.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void PlayerIconSelected(object sender, EventArgs e)
        {
            CharacterIcon sendingIcon = sender as CharacterIcon;

            if (sender != null)
            {
                SetSelectedToFalse(_playerIcons, sendingIcon);
                SetHighLevelsLocked(sendingIcon.Level);
                buttonReward.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        private void MonsterIconSelected(object sender, EventArgs e)
        {
            CharacterIcon sendingIcon = sender as CharacterIcon;
            if (sender != null)
            {
                SetSelectedToFalse(_monsterIcons, sendingIcon);
                labelHelp.Visible = false;
                buttonStart.Enabled = true;
            }
        }

        private void MonsterIconDeselected(object sender, EventArgs e)
        {
            CharacterIcon sendingIcon = sender as CharacterIcon;
            if (sender != null)
            {
                labelHelp.Visible = true;
                buttonStart.Enabled = false;
            }
        }

        private void ButtonReward_Click(object sender, EventArgs e)
        {
            int index = IndexOfChosenPlayer;
            Player player = _players[index];
            RewardMenu rewards = new RewardMenu(player.Stats.Gold);
            var result = rewards.ShowDialog();

            if (result == DialogResult.OK)
            {
                player.Stats.Intellect += rewards.Intellect;
                player.Stats.Spirit += rewards.Spirit;
                player.Stats.MaxHealthPoints += rewards.MaxHealth;
                player.Stats.MaxMana += rewards.MaxMana;
                player.Stats.Gold = rewards.Gold;
                //RefreshPlayer(index);
                PlayerUpdated?.Invoke(this, new PlayerEventArgs(player, index));
            }
        }
    }

    public class AddList<T> : List<T>
    {
        public event EventHandler OnAdd;
        public event EventHandler OnRemove;

        public new void Add(T item)
        {            
            base.Add(item);
            OnAdd?.Invoke(this, null);
        }

        public new void Remove(T item)
        {
            bool removed = base.Remove(item);
            if (OnRemove != null && removed) OnRemove(this, null);
        }
    }
}
