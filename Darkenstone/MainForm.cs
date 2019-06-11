using Darkenstone.Abilities;
using Darkenstone.Common;
using Darkenstone.Game;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class MainForm : Form
    {
        private UserControl _currentControl;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            mainMenu1.MainForm = this;
            opponentChoiceMenu1.MainForm = this;
            gamePlayControl1.MainForm = this;
            _currentControl = mainMenu1;

            opponentChoiceMenu1.PlayerAdded += new EventHandler<PlayerEventArgs>(AddCharacter);
            opponentChoiceMenu1.PlayerRemoved += new EventHandler<PlayerEventArgs>(DeleteCharacter);
            opponentChoiceMenu1.PlayerUpdated += new EventHandler<PlayerEventArgs>(AddCharacter);
            opponentChoiceMenu1.GameStarted += new EventHandler<GameEventArgs>(StartGame);
            
            LoadCharacters();
        }

        private void AddCharacter(object sender, PlayerEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(
                "Software\\Darkenstone\\Character" + e.Position);
            key.SetValue("CharacterName", e.Player.Stats.CharacterName);
            key.SetValue("Level", e.Player.Stats.Level);
            key.SetValue("MaxHealthPoints", e.Player.Stats.MaxHealthPoints);
            key.SetValue("Experience", e.Player.Stats.Experience);
            key.SetValue("Gold", e.Player.Stats.Gold);
            key.SetValue("MaxMana", e.Player.Stats.MaxMana);
            key.SetValue("Intellect", e.Player.Stats.Intellect);
            key.SetValue("Spirit", e.Player.Stats.Spirit);
            key.SetValue("IconColor", e.Player.Stats.IconColor.ToArgb());
            key.Close();
        }

        private void DeleteCharacter(object sender, PlayerEventArgs e)
        {       
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(
                    "Software\\Darkenstone");

            int maxCharPosition = opponentChoiceMenu1.Players.Count;

            if (e.Position == maxCharPosition)
            {
                registryKey.DeleteSubKeyTree("Character" + maxCharPosition.ToString());
            }        
            else
            {
                for (int i = e.Position; i < maxCharPosition; i++)
                {
                    RegistryUtilities.RenameSubKey(registryKey, "Character" + (i + 1).ToString(),
                        "Character" + i.ToString());
                }
            }           

            registryKey.Close();
        }

        private void LoadCharacters()
        {
            for (int i = 0; i < 5; i++)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    "Software\\Darkenstone\\Character" + i.ToString());
                if (key != null)
                {
                    string name = (string)key.GetValue("CharacterName", null);

                    if (name != null)
                    {
                        int maxHealthPoints = (int)key.GetValue("MaxHealthPoints", 300);
                        int level = (int)key.GetValue("Level", 1);
                        int experience = (int)key.GetValue("Experience", 0);
                        int gold = (int)key.GetValue("Gold", 0);
                        int maxMana = (int)key.GetValue("MaxMana", 100);
                        int intellect = (int)key.GetValue("Intellect", 10);
                        int spirit = (int)key.GetValue("Spirit", 10);                     
                        int color = (int)key.GetValue("IconColor", Color.FromArgb(64, 0, 64).ToArgb());
                        Color iconColor = Color.FromArgb(color);

                        Stats stats = new Stats(name, maxHealthPoints, level, experience, gold, maxMana,
                            intellect, spirit, iconColor);

                        Ability[] abilities = new Ability[] { new Fireshot(), new Fireball(), 
                            new Fireblast(), new FireBurns(), new Pyromaniac(), new FirstAid(),
                            new Rejuvenation(), new Growth(), new Meditation(), new Frenzy()};

                        opponentChoiceMenu1.Players.Add(new Player(stats, 
                            new List<Ability>(abilities)));
                    }
                    else
                    {
                        key.Close();
                        break;
                    }

                    key.Close();
                }
            }                      
        }

        private void SaveCharacter(Player player, int index)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(
                "Software\\Darkenstone\\Character" + index.ToString());
            key.SetValue("CharacterName", player.Stats.CharacterName);
            key.SetValue("Level", player.Stats.Level);
            key.SetValue("MaxHealthPoints", player.Stats.MaxHealthPoints);
            key.SetValue("Experience", player.Stats.Experience);
            key.SetValue("Gold", player.Stats.Gold);
            key.SetValue("MaxMana", player.Stats.MaxMana);
            key.SetValue("Intellect", player.Stats.Intellect);
            key.SetValue("Spirit", player.Stats.Spirit);
            key.SetValue("IconColor", player.Stats.IconColor.ToArgb());
            key.Close();
        }

        public void ShowPreviousControl()
        {
            if (_currentControl == mainMenu1)
            {
                Application.Exit();
            }
            else if (_currentControl == opponentChoiceMenu1)
            {
                mainMenu1.Show();
                _currentControl = mainMenu1;
            }
            else if (_currentControl == gamePlayControl1)
            {
                MessageWindow msgWindow = new MessageWindow("Do you really want to end this game?");
                var result = msgWindow.ShowDialog();

                if (result == DialogResult.OK)
                {
                    opponentChoiceMenu1.RefreshControl();
                    opponentChoiceMenu1.Show();
                    _currentControl = opponentChoiceMenu1;
                }                
            }
        }

        public void ShowNextControl()
        {
            _currentControl.Hide();

            if (_currentControl == mainMenu1)
            {
                _currentControl = opponentChoiceMenu1;
            }
            else if (_currentControl == opponentChoiceMenu1)
            {
                _currentControl = gamePlayControl1;
            }
        }

        public void StartGame(object sender, GameEventArgs e)
        {
            gamePlayControl1.GameManager = new GameManager(e.Player, e.Monster);
            gamePlayControl1.GameManager.GameOver += new EventHandler<GameEventArgs>(EndGame);
        }

        public void EndGame(object sender, GameEventArgs e)
        {
            string message;
            if (e.PlayerWon && e.Monster.Stats.CharacterName == "Darkenstone Dragon")
                message = "You beat the game! Congratulations!";
            else if (e.PlayerWon) message = "You won! Congratulations!";
            else message = "You lost! Sorry!";

            MessageWindow msgWindow = new MessageWindow(message);
            msgWindow.ShowDialog();

            int index = opponentChoiceMenu1.IndexOfChosenPlayer;
            SaveCharacter(e.Player, index);
            opponentChoiceMenu1.Players[index] = e.Player;
            opponentChoiceMenu1.RefreshPlayer(index);
            opponentChoiceMenu1.RefreshControl();
            opponentChoiceMenu1.Show();
            _currentControl = opponentChoiceMenu1;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ShowPreviousControl();
            }
        }
    }

    public static class RegistryUtilities
    {
        /// <summary>
        /// Renames a subkey of the passed in registry key since 
        /// the Framework totally forgot to include such a handy feature.
        /// </summary>
        /// <param name="parentKey">The RegistryKey that contains the subkey 
        /// you want to rename (must be writeable)</param>
        /// <param name="subKeyName">The name of the subkey that you want to rename
        /// </param>
        /// <param name="newSubKeyName">The new name of the RegistryKey</param>
        /// <returns>True if succeeds</returns>
        public static bool RenameSubKey(RegistryKey parentKey,
            string subKeyName, string newSubKeyName)
        {
            CopyKey(parentKey, subKeyName, newSubKeyName);
            parentKey.DeleteSubKeyTree(subKeyName);
            return true;
        }

        /// <summary>
        /// Copy a registry key.  The parentKey must be writeable.
        /// </summary>
        /// <param name="parentKey"></param>
        /// <param name="keyNameToCopy"></param>
        /// <param name="newKeyName"></param>
        /// <returns></returns>
        public static bool CopyKey(RegistryKey parentKey,
            string keyNameToCopy, string newKeyName)
        {
            //Create new key
            RegistryKey destinationKey = parentKey.CreateSubKey(newKeyName);

            //Open the sourceKey we are copying from
            RegistryKey sourceKey = parentKey.OpenSubKey(keyNameToCopy);

            RecurseCopyKey(sourceKey, destinationKey);

            return true;
        }

        private static void RecurseCopyKey(RegistryKey sourceKey, RegistryKey destinationKey)
        {
            //copy all the values
            foreach (string valueName in sourceKey.GetValueNames())
            {
                object objValue = sourceKey.GetValue(valueName);
                RegistryValueKind valKind = sourceKey.GetValueKind(valueName);
                destinationKey.SetValue(valueName, objValue, valKind);
            }

            //For Each subKey 
            //Create a new subKey in destinationKey 
            //Call myself 
            foreach (string sourceSubKeyName in sourceKey.GetSubKeyNames())
            {
                RegistryKey sourceSubKey = sourceKey.OpenSubKey(sourceSubKeyName);
                RegistryKey destSubKey = destinationKey.CreateSubKey(sourceSubKeyName);
                RecurseCopyKey(sourceSubKey, destSubKey);
            }
        }
    }

}
