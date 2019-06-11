using Darkenstone.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class CharacterIcon : UserControl
    {
        private bool _isSelected = false;
        private bool _isHighlighted = false;
        private bool _isSelectable = true;
        private bool _isLocked = false;
        private Character _character = null;

        public event EventHandler OnSelection;
        public event EventHandler OnDeselection;

        public Character Character
        {
            get { return _character; }
            set 
            {
                _character = value;
                if (_character != null)
                {
                    CharacterName = _character.Stats.CharacterName;
                    Level = _character.Stats.Level;
                    IconColor = _character.Stats.IconColor;
                    IsSelectable = true;
                    IsSelected = false;
                    IsHighlighted = false;
                    toolTipDetails.Active = true;
                }
                else
                {
                    CharacterName = "Character Name";
                    Level = 0;
                    IconColor = IconStyle.CharacterDefaultColor;
                    IsSelected = false;
                    IsHighlighted = false;
                    IsSelectable = false;
                    toolTipDetails.Active = false;
                }
            }
        }

        public Color IconColor
        {
            get { return panelIcon.BackColor; }
            set { panelIcon.BackColor = value; }
        }

        public Image Image
        {
            get { return panelIcon.BackgroundImage; }
            set { panelIcon.BackgroundImage = value; }
        }

        public string CharacterName
        {
            get { return labelCharName.Text; }
            set { labelCharName.Text = value; }
        }

        public int Level
        {
            get
            {
                int level = -1;
                int.TryParse(labelLevel.Text, out level);
                return level;
            }
            set 
            { 
                if (value == -1) labelLevel.Text = "?";
                else labelLevel.Text = value.ToString(); 
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (IsSelectable)
                {
                    if (value)
                    {
                        BackColor = CharacterIconStyle.SelectedColor;
                        OnSelection?.Invoke(this, null);
                    }
                    else
                    {
                        BackColor = CharacterIconStyle.BackColor;
                        OnDeselection?.Invoke(this, null);
                    }
                    _isSelected = value;
                }
            }
        }

        public bool IsHighlighted
        {
            get { return _isHighlighted; }
            set
            {
                if (IsSelectable)
                {
                    if (value)
                    {
                        panelCharName.BackColor = CharacterIconStyle.HighlightedColor;
                        labelCharName.BackColor = CharacterIconStyle.HighlightedColor;
                        labelLevel.BackColor = CharacterIconStyle.HighlightedColor;
                    }
                    else
                    {
                        panelCharName.BackColor = CharacterIconStyle.NotHighlightedColor;
                        labelCharName.BackColor = CharacterIconStyle.NotHighlightedColor;
                        labelLevel.BackColor = CharacterIconStyle.NotHighlightedColor;
                    }
                    _isHighlighted = value;
                }
            }
        }

        public bool IsSelectable
        {
            get { return _isSelectable; }
            set { _isSelectable = value; }
        }

        public bool IsLocked
        {
            get { return _isLocked; }
            set
            {
                if (value)
                {
                    _character = null;
                    CharacterName = "Character locked!";
                    Level = -1;
                    IsSelected = false;
                    IsHighlighted = false;
                    IsSelectable = false;
                    IconColor = IconStyle.CharacterDefaultColor;
                }
                else
                {
                    if (_character != null) { IconColor = _character.Stats.IconColor; }                    
                    IsSelectable = true;
                }

                _isLocked = value;
            }
        }

        public CharacterIcon()
        {
            InitializeComponent();            
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            IsHighlighted = true;

            if (IsSelectable)
            {
                string textToDisplay =
                        "Maximum health: " + _character.MaxHealthPoints + Environment.NewLine +
                        "Experience: " + _character.Stats.Experience + Environment.NewLine +
                        "Gold: " + _character.Stats.Gold + Environment.NewLine +
                        "Maximum Mana: " + _character.Stats.MaxMana + Environment.NewLine +
                        "Intellect: " + _character.Stats.Intellect + Environment.NewLine +
                        "Spirit: " + _character.Stats.Spirit;

                toolTipDetails.SetToolTip((Control)sender, textToDisplay);
                toolTipDetails.Active = true;
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            IsHighlighted = false;
            toolTipDetails.Active = false;
        }

        private void mouseClick(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;
        }
    }
}
