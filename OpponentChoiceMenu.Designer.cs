namespace Darkenstone
{
    partial class OpponentChoiceMenu
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelCharacters = new System.Windows.Forms.Label();
            this.characterIcon2 = new Darkenstone.CharacterIcon();
            this.characterIcon1 = new Darkenstone.CharacterIcon();
            this.characterIcon3 = new Darkenstone.CharacterIcon();
            this.characterIcon4 = new Darkenstone.CharacterIcon();
            this.characterIcon5 = new Darkenstone.CharacterIcon();
            this.playerIcon1 = new Darkenstone.CharacterIcon();
            this.playerIcon2 = new Darkenstone.CharacterIcon();
            this.playerIcon3 = new Darkenstone.CharacterIcon();
            this.playerIcon4 = new Darkenstone.CharacterIcon();
            this.playerIcon5 = new Darkenstone.CharacterIcon();
            this.labelOpponent = new System.Windows.Forms.Label();
            this.labelHelp = new System.Windows.Forms.Label();
            this.buttonReward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = ButtonStyle.BackColor;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = ButtonStyle.TextColor;
            this.buttonAdd.Location = new System.Drawing.Point(38, 382);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = ButtonStyle.BackColor;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReturn.ForeColor = ButtonStyle.TextColor;
            this.buttonReturn.Location = new System.Drawing.Point(38, 446);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(152, 35);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = ButtonStyle.BackColor;
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = ButtonStyle.TextColor;
            this.buttonStart.Location = new System.Drawing.Point(706, 446);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 35);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Game!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = ButtonStyle.BackColor;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = ButtonStyle.TextColor;
            this.buttonDelete.Location = new System.Drawing.Point(209, 382);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 35);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelCharacters
            // 
            this.labelCharacters.AutoSize = true;
            this.labelCharacters.BackColor = LabelStyle.TransparentBackColor;
            this.labelCharacters.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCharacters.ForeColor = LabelStyle.TextColor;
            this.labelCharacters.Location = new System.Drawing.Point(103, 28);
            this.labelCharacters.Name = "labelCharacters";
            this.labelCharacters.Size = new System.Drawing.Size(287, 34);
            this.labelCharacters.TabIndex = 5;
            this.labelCharacters.Text = "Player characters";
            // 
            // characterIcon2
            // 
            this.characterIcon2.BackColor = IconStyle.BackColor;
            this.characterIcon2.Character = null;
            this.characterIcon2.CharacterName = "Character Name";
            this.characterIcon2.IconColor = IconStyle.IconColor;
            this.characterIcon2.Image = null;
            this.characterIcon2.IsHighlighted = false;
            this.characterIcon2.IsLocked = false;
            this.characterIcon2.IsSelectable = true;
            this.characterIcon2.IsSelected = false;
            this.characterIcon2.Level = 0;
            this.characterIcon2.Location = new System.Drawing.Point(551, 125);
            this.characterIcon2.Name = "characterIcon2";
            this.characterIcon2.Size = new System.Drawing.Size(250, 54);
            this.characterIcon2.TabIndex = 9;
            // 
            // characterIcon1
            // 
            this.characterIcon1.BackColor = IconStyle.BackColor;
            this.characterIcon1.Character = null;
            this.characterIcon1.CharacterName = "Character Name";
            this.characterIcon1.IconColor = IconStyle.IconColor;
            this.characterIcon1.Image = null;
            this.characterIcon1.IsHighlighted = false;
            this.characterIcon1.IsLocked = false;
            this.characterIcon1.IsSelectable = true;
            this.characterIcon1.IsSelected = false;
            this.characterIcon1.Level = 0;
            this.characterIcon1.Location = new System.Drawing.Point(551, 65);
            this.characterIcon1.Name = "characterIcon1";
            this.characterIcon1.Size = new System.Drawing.Size(250, 54);
            this.characterIcon1.TabIndex = 10;
            // 
            // characterIcon3
            // 
            this.characterIcon3.BackColor = IconStyle.BackColor;
            this.characterIcon3.Character = null;
            this.characterIcon3.CharacterName = "Character Name";
            this.characterIcon3.IconColor = IconStyle.IconColor;
            this.characterIcon3.Image = null;
            this.characterIcon3.IsHighlighted = false;
            this.characterIcon3.IsLocked = false;
            this.characterIcon3.IsSelectable = true;
            this.characterIcon3.IsSelected = false;
            this.characterIcon3.Level = 0;
            this.characterIcon3.Location = new System.Drawing.Point(551, 185);
            this.characterIcon3.Name = "characterIcon3";
            this.characterIcon3.Size = new System.Drawing.Size(250, 54);
            this.characterIcon3.TabIndex = 11;
            // 
            // characterIcon4
            // 
            this.characterIcon4.BackColor = IconStyle.BackColor;
            this.characterIcon4.Character = null;
            this.characterIcon4.CharacterName = "Character Name";
            this.characterIcon4.IconColor = IconStyle.IconColor;
            this.characterIcon4.Image = null;
            this.characterIcon4.IsHighlighted = false;
            this.characterIcon4.IsLocked = false;
            this.characterIcon4.IsSelectable = true;
            this.characterIcon4.IsSelected = false;
            this.characterIcon4.Level = 0;
            this.characterIcon4.Location = new System.Drawing.Point(551, 246);
            this.characterIcon4.Name = "characterIcon4";
            this.characterIcon4.Size = new System.Drawing.Size(250, 54);
            this.characterIcon4.TabIndex = 12;
            // 
            // characterIcon5
            // 
            this.characterIcon5.BackColor = IconStyle.BackColor;
            this.characterIcon5.Character = null;
            this.characterIcon5.CharacterName = "Character Name";
            this.characterIcon5.IconColor = IconStyle.IconColor;
            this.characterIcon5.Image = null;
            this.characterIcon5.IsHighlighted = false;
            this.characterIcon5.IsLocked = false;
            this.characterIcon5.IsSelectable = true;
            this.characterIcon5.IsSelected = false;
            this.characterIcon5.Level = 0;
            this.characterIcon5.Location = new System.Drawing.Point(551, 306);
            this.characterIcon5.Name = "characterIcon5";
            this.characterIcon5.Size = new System.Drawing.Size(250, 54);
            this.characterIcon5.TabIndex = 13;
            // 
            // playerIcon1
            // 
            this.playerIcon1.BackColor = IconStyle.BackColor;
            this.playerIcon1.Character = null;
            this.playerIcon1.CharacterName = "Character Name";
            this.playerIcon1.IconColor = IconStyle.IconColor;
            this.playerIcon1.Image = null;
            this.playerIcon1.IsHighlighted = false;
            this.playerIcon1.IsLocked = false;
            this.playerIcon1.IsSelectable = true;
            this.playerIcon1.IsSelected = false;
            this.playerIcon1.Level = 0;
            this.playerIcon1.Location = new System.Drawing.Point(122, 65);
            this.playerIcon1.Name = "playerIcon1";
            this.playerIcon1.Size = new System.Drawing.Size(250, 54);
            this.playerIcon1.TabIndex = 14;
            this.playerIcon1.Visible = false;
            // 
            // playerIcon2
            // 
            this.playerIcon2.BackColor = IconStyle.BackColor;
            this.playerIcon2.Character = null;
            this.playerIcon2.CharacterName = "Character Name";
            this.playerIcon2.IconColor = IconStyle.IconColor;
            this.playerIcon2.Image = null;
            this.playerIcon2.IsHighlighted = false;
            this.playerIcon2.IsLocked = false;
            this.playerIcon2.IsSelectable = true;
            this.playerIcon2.IsSelected = false;
            this.playerIcon2.Level = 0;
            this.playerIcon2.Location = new System.Drawing.Point(122, 125);
            this.playerIcon2.Name = "playerIcon2";
            this.playerIcon2.Size = new System.Drawing.Size(250, 54);
            this.playerIcon2.TabIndex = 15;
            this.playerIcon2.Visible = false;
            // 
            // playerIcon3
            // 
            this.playerIcon3.BackColor = IconStyle.BackColor;
            this.playerIcon3.Character = null;
            this.playerIcon3.CharacterName = "Character Name";
            this.playerIcon3.IconColor = IconStyle.IconColor;
            this.playerIcon3.Image = null;
            this.playerIcon3.IsHighlighted = false;
            this.playerIcon3.IsLocked = false;
            this.playerIcon3.IsSelectable = true;
            this.playerIcon3.IsSelected = false;
            this.playerIcon3.Level = 0;
            this.playerIcon3.Location = new System.Drawing.Point(122, 185);
            this.playerIcon3.Name = "playerIcon3";
            this.playerIcon3.Size = new System.Drawing.Size(250, 54);
            this.playerIcon3.TabIndex = 16;
            this.playerIcon3.Visible = false;
            // 
            // playerIcon4
            // 
            this.playerIcon4.BackColor = IconStyle.BackColor;
            this.playerIcon4.Character = null;
            this.playerIcon4.CharacterName = "Character Name";
            this.playerIcon4.IconColor = IconStyle.IconColor;
            this.playerIcon4.Image = null;
            this.playerIcon4.IsHighlighted = false;
            this.playerIcon4.IsLocked = false;
            this.playerIcon4.IsSelectable = true;
            this.playerIcon4.IsSelected = false;
            this.playerIcon4.Level = 0;
            this.playerIcon4.Location = new System.Drawing.Point(122, 246);
            this.playerIcon4.Name = "playerIcon4";
            this.playerIcon4.Size = new System.Drawing.Size(250, 54);
            this.playerIcon4.TabIndex = 17;
            this.playerIcon4.Visible = false;
            // 
            // playerIcon5
            // 
            this.playerIcon5.BackColor = IconStyle.BackColor;
            this.playerIcon5.Character = null;
            this.playerIcon5.CharacterName = "Character Name";
            this.playerIcon5.IconColor = IconStyle.IconColor;
            this.playerIcon5.Image = null;
            this.playerIcon5.IsHighlighted = false;
            this.playerIcon5.IsLocked = false;
            this.playerIcon5.IsSelectable = true;
            this.playerIcon5.IsSelected = false;
            this.playerIcon5.Level = 0;
            this.playerIcon5.Location = new System.Drawing.Point(122, 306);
            this.playerIcon5.Name = "playerIcon5";
            this.playerIcon5.Size = new System.Drawing.Size(250, 54);
            this.playerIcon5.TabIndex = 18;
            this.playerIcon5.Visible = false;
            // 
            // labelOpponent
            // 
            this.labelOpponent.AutoSize = true;
            this.labelOpponent.BackColor = LabelStyle.TransparentBackColor;
            this.labelOpponent.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpponent.ForeColor = LabelStyle.TextColor;
            this.labelOpponent.Location = new System.Drawing.Point(521, 28);
            this.labelOpponent.Name = "labelOpponent";
            this.labelOpponent.Size = new System.Drawing.Size(319, 34);
            this.labelOpponent.TabIndex = 19;
            this.labelOpponent.Text = "Opponent characters";
            // 
            // labelHelp
            // 
            this.labelHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHelp.ForeColor = LabelStyle.TextColor;
            this.labelHelp.Location = new System.Drawing.Point(399, 125);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(128, 114);
            this.labelHelp.TabIndex = 20;
            this.labelHelp.Text = "Choose 1 character and fight 1 opponent!";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReward
            // 
            this.buttonReward.BackColor = ButtonStyle.BackColor;
            this.buttonReward.Enabled = false;
            this.buttonReward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReward.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReward.ForeColor = ButtonStyle.TextColor;
            this.buttonReward.Location = new System.Drawing.Point(375, 382);
            this.buttonReward.Name = "buttonReward";
            this.buttonReward.Size = new System.Drawing.Size(152, 35);
            this.buttonReward.TabIndex = 21;
            this.buttonReward.Text = "Rewards";
            this.buttonReward.UseVisualStyleBackColor = false;
            this.buttonReward.Click += new System.EventHandler(this.ButtonReward_Click);
            // 
            // OpponentChoiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = FormStyle.BackColor;
            this.Controls.Add(this.buttonReward);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.labelOpponent);
            this.Controls.Add(this.playerIcon5);
            this.Controls.Add(this.playerIcon4);
            this.Controls.Add(this.playerIcon3);
            this.Controls.Add(this.playerIcon2);
            this.Controls.Add(this.playerIcon1);
            this.Controls.Add(this.characterIcon5);
            this.Controls.Add(this.characterIcon4);
            this.Controls.Add(this.characterIcon3);
            this.Controls.Add(this.characterIcon1);
            this.Controls.Add(this.characterIcon2);
            this.Controls.Add(this.labelCharacters);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAdd);
            this.Name = "OpponentChoiceMenu";
            this.Size = new System.Drawing.Size(900, 507);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelCharacters;
        private CharacterIcon characterIcon2;
        private CharacterIcon characterIcon1;
        private CharacterIcon characterIcon3;
        private CharacterIcon characterIcon4;
        private CharacterIcon characterIcon5;
        private CharacterIcon playerIcon1;
        private CharacterIcon playerIcon2;
        private CharacterIcon playerIcon3;
        private CharacterIcon playerIcon4;
        private CharacterIcon playerIcon5;
        private System.Windows.Forms.Label labelOpponent;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Button buttonReward;
    }
}
