using Darkenstone.Abilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class AbilityCard : UserControl
    {
        private bool _isHighlighted = false;
        private bool _isSelected = false;
        private bool _isSelectable = true;
        private bool _isVacant = false;
        private Ability _ability;

        public Ability Ability
        {
            get { return _ability; }
            set 
            {
                _ability = value;
                if (_ability != null)
                {
                    AbilityName = _ability.Name;
                    Description = _ability.Description;
                    CoolDown = _ability.CoolDown;
                    CastTime = _ability.CastTime;
                    ManaCost = _ability.ManaCost;
                    IsOffensive = _ability.Offensive;
                    IsVacant = false;
                }
                else IsVacant = true;
            }
        }

        public string AbilityName
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }

        public string Description
        {
            get { return labelDescription.Text; }
            set { labelDescription.Text = value; }
        }

        public int CoolDown
        {
            get
            {
                int coolDown = 0;
                int.TryParse(labelCoolDown.Text, out coolDown);
                return coolDown;
            }
            set { labelCoolDown.Text = value.ToString(); }
        }

        public int CastTime
        {
            get
            {
                int castTime = 0;
                int.TryParse(labelCastTime.Text, out castTime);
                return castTime;
            }
            set { labelCastTime.Text = value.ToString(); }
        }

        public int ManaCost
        {
            get
            {
                int manaCost = 0;
                int.TryParse(labelManaCost.Text, out manaCost);
                return manaCost;
            }
            set { labelManaCost.Text = value.ToString(); }
        }

        public bool IsOffensive
        {
            get { return panelOffensive.BackColor == OffensivenessStyle.OffensiveColor; }
            set
            {
                if (value) panelOffensive.BackColor = OffensivenessStyle.OffensiveColor;
                else panelOffensive.BackColor = OffensivenessStyle.DefensiveColor;
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
                        labelName.BackColor = LabelStyle.HighlightedBackColor;
                        labelDescription.BackColor = LabelStyle.HighlightedBackColor;
                        labelCoolDown.BackColor = LabelStyle.HighlightedBackColor;
                        labelCastTime.BackColor = LabelStyle.HighlightedBackColor;
                    }
                    else
                    {
                        labelName.BackColor = LabelStyle.BackColor;
                        labelDescription.BackColor = LabelStyle.BackColor;
                        labelCoolDown.BackColor = LabelStyle.BackColor;
                        labelCastTime.BackColor = LabelStyle.BackColor;
                    }
                    _isHighlighted = value;
                }
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (IsSelectable)
                {
                    if (value) BackColor = AbilityCardStyle.SelectedBackColor;
                    else BackColor = AbilityCardStyle.BackColor;
                    _isSelected = value;
                }
            }
        }

        public bool IsSelectable
        {
            get { return _isSelectable; }
            set { _isSelectable = value; }
        }

        public bool IsVacant
        {
            get { return _isVacant; }
            set
            {
                if (value)
                {
                    panelCover.Visible = true;
                    IsSelectable = false;
                }
                else
                {
                    panelCover.Visible = false;
                    IsSelectable = true;
                }
                _isVacant = value;
            }
        }

        public bool DropAllowed { get; set; }

        public AbilityContainer ParentContainer { get; set; }

        public AbilityCard()
        {
            InitializeComponent();
            DropAllowed = false;
            toolTipCoolDown.SetToolTip(labelCoolDown, "Cooldown: The amount of rounds before " +
                "you can use the ability again.");
            toolTipManaCost.SetToolTip(labelManaCost, "Mana cost: The amount of mana you " +
                "will lose upon using the ability.");
            toolTipOffensive.SetToolTip(panelOffensive, "Red abilities hurt your enemy, " +
                "green benefit you.");
            toolTipCastTime.SetToolTip(labelCastTime, "Cast time: The amount of rounds before " +
                "the ability takes effect.");
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            IsHighlighted = true;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            IsHighlighted = false;
        }

        /*
        private void mouseClick(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;
        }
        */

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (IsSelectable && ParentContainer == null) DoDragDrop(this, DragDropEffects.Copy);
        }

        private void dragEnter(object sender, DragEventArgs e)
        {
            if (DropAllowed) e.Effect = DragDropEffects.Copy;
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            AbilityCard sendingCard = e.Data.GetData(typeof(AbilityCard)) as AbilityCard;

            Ability = sendingCard.Ability;
            IsVacant = false;
            
            if (ParentContainer != null) ParentContainer.AbilityCardDropped(sendingCard, null);
        }
    }
}
