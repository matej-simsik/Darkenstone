using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Darkenstone.Abilities;

namespace Darkenstone
{
    public partial class AbilityContainer : UserControl
    {
        private bool _isVacant = true;
        private AbilityCard _copiedCard = null;

        public Ability Ability
        {
            get { return abilityCard.Ability; }
            set 
            { 
                abilityCard.Ability = value;
                if (value == null)
                {
                    IsVacant = true;
                    CopiedCard = null;
                }
            }
        }

        public AbilityCard AbilityCard
        {
            get { return abilityCard; }
            private set { abilityCard = value; }
        }

        public AbilityCard CopiedCard
        {
            get { return _copiedCard; }
            private set { _copiedCard = value; }
        }

        public bool IsVacant
        {
            get { return _isVacant; }
            set 
            {
                if (value)
                {
                    abilityCard.IsVacant = true;
                    closeButton.Visible = false;
                }
                else closeButton.Visible = true;

                _isVacant = value;
            }
        }

        public AbilityContainer()
        {
            InitializeComponent();
            abilityCard.DropAllowed = true;
            abilityCard.IsVacant = true;
            abilityCard.ParentContainer = this;
        }

        public void AbilityCardDropped(object sender, EventArgs e)
        {
            IsVacant = false;

            if (sender is AbilityCard sendingCard)
            {
                //If the copied card was vacated due to cooldown, enable it again.
                if (CopiedCard != null) CopiedCard.IsVacant = false;
                CopiedCard = sendingCard;
                if (CopiedCard.CoolDown > 0) CopiedCard.IsVacant = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            IsVacant = true;

            if (CopiedCard != null)
            {
                CopiedCard.IsVacant = false;
                CopiedCard = null;
            }
        }
    }

    public class RoundButton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(2, 2, Width - 5, Height - 5));
                Region = new Region(path);
            }
            base.OnResize(e);
        }
    }
}
