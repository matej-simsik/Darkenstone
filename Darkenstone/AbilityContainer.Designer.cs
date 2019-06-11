namespace Darkenstone
{
    partial class AbilityContainer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new Darkenstone.RoundButton();
            this.abilityCard = new Darkenstone.AbilityCard();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = CloseButtonStyle.BackColor;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = CloseButtonStyle.TextColor;
            this.closeButton.Location = new System.Drawing.Point(139, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // abilityCard
            // 
            this.abilityCard.AbilityName = "NAME";
            this.abilityCard.AllowDrop = true;
            this.abilityCard.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard.CoolDown = 0;
            this.abilityCard.Description = "Description\r\nabout the spell";
            this.abilityCard.DropAllowed = false;
            this.abilityCard.IsHighlighted = false;
            this.abilityCard.IsSelectable = true;
            this.abilityCard.IsSelected = false;
            this.abilityCard.IsVacant = false;
            this.abilityCard.Location = new System.Drawing.Point(0, 16);
            this.abilityCard.ManaCost = 0;
            this.abilityCard.Name = "abilityCard";
            this.abilityCard.IsOffensive = false;
            this.abilityCard.ParentContainer = null;
            this.abilityCard.Size = new System.Drawing.Size(154, 104);
            this.abilityCard.TabIndex = 0;
            // 
            // AbilityContainer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AbilityCardContainerStyle.BackColor;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.abilityCard);
            this.Name = "AbilityContainer";
            this.Size = new System.Drawing.Size(170, 124);
            this.ResumeLayout(false);

        }

        #endregion

        private AbilityCard abilityCard;
        private RoundButton closeButton;
    }
}
