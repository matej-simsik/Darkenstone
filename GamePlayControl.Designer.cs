namespace Darkenstone
{
    partial class GamePlayControl
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
            this.components = new System.ComponentModel.Container();
            this.buttonFinishRound = new System.Windows.Forms.Button();
            this.playerManaBar = new SmoothProgressBar.SmoothProgressBar();
            this.monsterHealthBar = new SmoothProgressBar.SmoothProgressBar();
            this.playerHealthBar = new SmoothProgressBar.SmoothProgressBar();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.toolTipResource = new System.Windows.Forms.ToolTip(this.components);
            this.abilityCardMonster = new Darkenstone.AbilityCard();
            this.abilityCard10 = new Darkenstone.AbilityCard();
            this.abilityCard5 = new Darkenstone.AbilityCard();
            this.abilityCard9 = new Darkenstone.AbilityCard();
            this.abilityCard4 = new Darkenstone.AbilityCard();
            this.abilityCard8 = new Darkenstone.AbilityCard();
            this.abilityCard3 = new Darkenstone.AbilityCard();
            this.abilityCard7 = new Darkenstone.AbilityCard();
            this.abilityCard2 = new Darkenstone.AbilityCard();
            this.abilityCard6 = new Darkenstone.AbilityCard();
            this.abilityContainer3 = new Darkenstone.AbilityContainer();
            this.abilityContainer2 = new Darkenstone.AbilityContainer();
            this.abilityContainer1 = new Darkenstone.AbilityContainer();
            this.abilityCard1 = new Darkenstone.AbilityCard();
            this.monsterIcon = new Darkenstone.CharacterIcon();
            this.playerIcon = new Darkenstone.CharacterIcon();
            this.SuspendLayout();
            // 
            // buttonFinishRound
            // 
            this.buttonFinishRound.BackColor = ButtonStyle.BackColor;
            this.buttonFinishRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinishRound.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFinishRound.ForeColor = ButtonStyle.TextColor;
            this.buttonFinishRound.Location = new System.Drawing.Point(725, 422);
            this.buttonFinishRound.Name = "buttonFinishRound";
            this.buttonFinishRound.Size = new System.Drawing.Size(155, 35);
            this.buttonFinishRound.TabIndex = 14;
            this.buttonFinishRound.Text = "Finish Round";
            this.buttonFinishRound.UseVisualStyleBackColor = false;
            this.buttonFinishRound.Click += new System.EventHandler(this.ButtonFinishRound_Click);
            // 
            // playerManaBar
            // 
            this.playerManaBar.Location = new System.Drawing.Point(20, 109);
            this.playerManaBar.Maximum = 100;
            this.playerManaBar.Minimum = 0;
            this.playerManaBar.Name = "playerManaBar";
            this.playerManaBar.ProgressBarColor = ResourceStyle.ManaColor;
            this.playerManaBar.Size = new System.Drawing.Size(250, 30);
            this.playerManaBar.TabIndex = 31;
            this.playerManaBar.Value = 100;
            this.playerManaBar.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.playerManaBar.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.Location = new System.Drawing.Point(630, 73);
            this.monsterHealthBar.Maximum = 100;
            this.monsterHealthBar.Minimum = 0;
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.ProgressBarColor = ResourceStyle.HealthColor;
            this.monsterHealthBar.Size = new System.Drawing.Size(250, 30);
            this.monsterHealthBar.TabIndex = 32;
            this.monsterHealthBar.Value = 100;
            this.monsterHealthBar.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.monsterHealthBar.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(20, 73);
            this.playerHealthBar.Maximum = 100;
            this.playerHealthBar.Minimum = 0;
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.ProgressBarColor = ResourceStyle.HealthColor;
            this.playerHealthBar.Size = new System.Drawing.Size(250, 30);
            this.playerHealthBar.TabIndex = 33;
            this.playerHealthBar.Value = 100;
            this.playerHealthBar.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.playerHealthBar.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.ForeColor = LabelStyle.TextColor;
            this.labelInfo.Location = new System.Drawing.Point(322, 118);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(263, 30);
            this.labelInfo.TabIndex = 34;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.BackColor = ButtonStyle.BackColor;
            this.buttonEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndGame.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEndGame.ForeColor = ButtonStyle.TextColor;
            this.buttonEndGame.Location = new System.Drawing.Point(20, 422);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(155, 35);
            this.buttonEndGame.TabIndex = 35;
            this.buttonEndGame.Text = "End Game";
            this.buttonEndGame.UseVisualStyleBackColor = false;
            this.buttonEndGame.Click += new System.EventHandler(this.ButtonEndGame_Click);
            // 
            // toolTipResource
            // 
            this.toolTipResource.BackColor = ToolTipStyle.BackColor;
            this.toolTipResource.ForeColor = ToolTipStyle.TextColor;
            // 
            // abilityCardMonster
            // 
            this.abilityCardMonster.Ability = null;
            this.abilityCardMonster.AbilityName = "NAME";
            this.abilityCardMonster.AllowDrop = true;
            this.abilityCardMonster.BackColor = AbilityCardStyle.BackColor;
            this.abilityCardMonster.CastTime = 0;
            this.abilityCardMonster.CoolDown = 0;
            this.abilityCardMonster.Description = "Description\r\nabout the spell";
            this.abilityCardMonster.DropAllowed = false;
            this.abilityCardMonster.IsHighlighted = false;
            this.abilityCardMonster.IsSelectable = true;
            this.abilityCardMonster.IsSelected = false;
            this.abilityCardMonster.IsVacant = false;
            this.abilityCardMonster.Location = new System.Drawing.Point(373, 13);
            this.abilityCardMonster.ManaCost = 0;
            this.abilityCardMonster.Name = "abilityCardMonster";
            this.abilityCardMonster.IsOffensive = false;
            this.abilityCardMonster.ParentContainer = null;
            this.abilityCardMonster.Size = new System.Drawing.Size(154, 104);
            this.abilityCardMonster.TabIndex = 36;
            // 
            // abilityCard10
            // 
            this.abilityCard10.Ability = null;
            this.abilityCard10.AbilityName = "NAME";
            this.abilityCard10.AllowDrop = true;
            this.abilityCard10.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard10.CastTime = 0;
            this.abilityCard10.CoolDown = 0;
            this.abilityCard10.Description = "Description\r\nabout the spell";
            this.abilityCard10.DropAllowed = false;
            this.abilityCard10.IsHighlighted = false;
            this.abilityCard10.IsSelectable = true;
            this.abilityCard10.IsSelected = false;
            this.abilityCard10.IsVacant = false;
            this.abilityCard10.Location = new System.Drawing.Point(726, 261);
            this.abilityCard10.ManaCost = 0;
            this.abilityCard10.Name = "abilityCard10";
            this.abilityCard10.IsOffensive = false;
            this.abilityCard10.ParentContainer = null;
            this.abilityCard10.Size = new System.Drawing.Size(154, 104);
            this.abilityCard10.TabIndex = 27;
            // 
            // abilityCard5
            // 
            this.abilityCard5.Ability = null;
            this.abilityCard5.AbilityName = "NAME";
            this.abilityCard5.AllowDrop = true;
            this.abilityCard5.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard5.CastTime = 0;
            this.abilityCard5.CoolDown = 0;
            this.abilityCard5.Description = "Description\r\nabout the spell";
            this.abilityCard5.DropAllowed = false;
            this.abilityCard5.IsHighlighted = false;
            this.abilityCard5.IsSelectable = true;
            this.abilityCard5.IsSelected = false;
            this.abilityCard5.IsVacant = false;
            this.abilityCard5.Location = new System.Drawing.Point(726, 151);
            this.abilityCard5.ManaCost = 0;
            this.abilityCard5.Name = "abilityCard5";
            this.abilityCard5.IsOffensive = false;
            this.abilityCard5.ParentContainer = null;
            this.abilityCard5.Size = new System.Drawing.Size(154, 104);
            this.abilityCard5.TabIndex = 26;
            // 
            // abilityCard9
            // 
            this.abilityCard9.Ability = null;
            this.abilityCard9.AbilityName = "NAME";
            this.abilityCard9.AllowDrop = true;
            this.abilityCard9.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard9.CastTime = 0;
            this.abilityCard9.CoolDown = 0;
            this.abilityCard9.Description = "Description\r\nabout the spell";
            this.abilityCard9.DropAllowed = false;
            this.abilityCard9.IsHighlighted = false;
            this.abilityCard9.IsSelectable = true;
            this.abilityCard9.IsSelected = false;
            this.abilityCard9.IsVacant = false;
            this.abilityCard9.Location = new System.Drawing.Point(549, 261);
            this.abilityCard9.ManaCost = 0;
            this.abilityCard9.Name = "abilityCard9";
            this.abilityCard9.IsOffensive = false;
            this.abilityCard9.ParentContainer = null;
            this.abilityCard9.Size = new System.Drawing.Size(154, 104);
            this.abilityCard9.TabIndex = 25;
            // 
            // abilityCard4
            // 
            this.abilityCard4.Ability = null;
            this.abilityCard4.AbilityName = "NAME";
            this.abilityCard4.AllowDrop = true;
            this.abilityCard4.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard4.CastTime = 0;
            this.abilityCard4.CoolDown = 0;
            this.abilityCard4.Description = "Description\r\nabout the spell";
            this.abilityCard4.DropAllowed = false;
            this.abilityCard4.IsHighlighted = false;
            this.abilityCard4.IsSelectable = true;
            this.abilityCard4.IsSelected = false;
            this.abilityCard4.IsVacant = false;
            this.abilityCard4.Location = new System.Drawing.Point(549, 151);
            this.abilityCard4.ManaCost = 0;
            this.abilityCard4.Name = "abilityCard4";
            this.abilityCard4.IsOffensive = false;
            this.abilityCard4.ParentContainer = null;
            this.abilityCard4.Size = new System.Drawing.Size(154, 104);
            this.abilityCard4.TabIndex = 24;
            // 
            // abilityCard8
            // 
            this.abilityCard8.Ability = null;
            this.abilityCard8.AbilityName = "NAME";
            this.abilityCard8.AllowDrop = true;
            this.abilityCard8.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard8.CastTime = 0;
            this.abilityCard8.CoolDown = 0;
            this.abilityCard8.Description = "Description\r\nabout the spell";
            this.abilityCard8.DropAllowed = false;
            this.abilityCard8.IsHighlighted = false;
            this.abilityCard8.IsSelectable = true;
            this.abilityCard8.IsSelected = false;
            this.abilityCard8.IsVacant = false;
            this.abilityCard8.Location = new System.Drawing.Point(373, 261);
            this.abilityCard8.ManaCost = 0;
            this.abilityCard8.Name = "abilityCard8";
            this.abilityCard8.IsOffensive = false;
            this.abilityCard8.ParentContainer = null;
            this.abilityCard8.Size = new System.Drawing.Size(154, 104);
            this.abilityCard8.TabIndex = 23;
            // 
            // abilityCard3
            // 
            this.abilityCard3.Ability = null;
            this.abilityCard3.AbilityName = "NAME";
            this.abilityCard3.AllowDrop = true;
            this.abilityCard3.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard3.CastTime = 0;
            this.abilityCard3.CoolDown = 0;
            this.abilityCard3.Description = "Description\r\nabout the spell";
            this.abilityCard3.DropAllowed = false;
            this.abilityCard3.IsHighlighted = false;
            this.abilityCard3.IsSelectable = true;
            this.abilityCard3.IsSelected = false;
            this.abilityCard3.IsVacant = false;
            this.abilityCard3.Location = new System.Drawing.Point(373, 151);
            this.abilityCard3.ManaCost = 0;
            this.abilityCard3.Name = "abilityCard3";
            this.abilityCard3.IsOffensive = false;
            this.abilityCard3.ParentContainer = null;
            this.abilityCard3.Size = new System.Drawing.Size(154, 104);
            this.abilityCard3.TabIndex = 22;
            // 
            // abilityCard7
            // 
            this.abilityCard7.Ability = null;
            this.abilityCard7.AbilityName = "NAME";
            this.abilityCard7.AllowDrop = true;
            this.abilityCard7.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard7.CastTime = 0;
            this.abilityCard7.CoolDown = 0;
            this.abilityCard7.Description = "Description\r\nabout the spell";
            this.abilityCard7.DropAllowed = false;
            this.abilityCard7.IsHighlighted = false;
            this.abilityCard7.IsSelectable = true;
            this.abilityCard7.IsSelected = false;
            this.abilityCard7.IsVacant = false;
            this.abilityCard7.Location = new System.Drawing.Point(196, 261);
            this.abilityCard7.ManaCost = 0;
            this.abilityCard7.Name = "abilityCard7";
            this.abilityCard7.IsOffensive = false;
            this.abilityCard7.ParentContainer = null;
            this.abilityCard7.Size = new System.Drawing.Size(154, 104);
            this.abilityCard7.TabIndex = 21;
            // 
            // abilityCard2
            // 
            this.abilityCard2.Ability = null;
            this.abilityCard2.AbilityName = "NAME";
            this.abilityCard2.AllowDrop = true;
            this.abilityCard2.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard2.CastTime = 0;
            this.abilityCard2.CoolDown = 0;
            this.abilityCard2.Description = "Description\r\nabout the spell";
            this.abilityCard2.DropAllowed = false;
            this.abilityCard2.IsHighlighted = false;
            this.abilityCard2.IsSelectable = true;
            this.abilityCard2.IsSelected = false;
            this.abilityCard2.IsVacant = false;
            this.abilityCard2.Location = new System.Drawing.Point(196, 151);
            this.abilityCard2.ManaCost = 0;
            this.abilityCard2.Name = "abilityCard2";
            this.abilityCard2.IsOffensive = false;
            this.abilityCard2.ParentContainer = null;
            this.abilityCard2.Size = new System.Drawing.Size(154, 104);
            this.abilityCard2.TabIndex = 20;
            // 
            // abilityCard6
            // 
            this.abilityCard6.Ability = null;
            this.abilityCard6.AbilityName = "NAME";
            this.abilityCard6.AllowDrop = true;
            this.abilityCard6.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard6.CastTime = 0;
            this.abilityCard6.CoolDown = 0;
            this.abilityCard6.Description = "Description\r\nabout the spell";
            this.abilityCard6.DropAllowed = false;
            this.abilityCard6.IsHighlighted = false;
            this.abilityCard6.IsSelectable = true;
            this.abilityCard6.IsSelected = false;
            this.abilityCard6.IsVacant = false;
            this.abilityCard6.Location = new System.Drawing.Point(20, 261);
            this.abilityCard6.ManaCost = 0;
            this.abilityCard6.Name = "abilityCard6";
            this.abilityCard6.IsOffensive = false;
            this.abilityCard6.ParentContainer = null;
            this.abilityCard6.Size = new System.Drawing.Size(154, 104);
            this.abilityCard6.TabIndex = 19;
            // 
            // abilityContainer3
            // 
            this.abilityContainer3.Ability = null;
            this.abilityContainer3.AllowDrop = true;
            this.abilityContainer3.BackColor = AbilityCardContainerStyle.BackColor;
            this.abilityContainer3.IsVacant = true;
            this.abilityContainer3.Location = new System.Drawing.Point(549, 370);
            this.abilityContainer3.Name = "abilityContainer3";
            this.abilityContainer3.Size = new System.Drawing.Size(170, 124);
            this.abilityContainer3.TabIndex = 18;
            // 
            // abilityContainer2
            // 
            this.abilityContainer2.Ability = null;
            this.abilityContainer2.AllowDrop = true;
            this.abilityContainer2.BackColor = AbilityCardContainerStyle.BackColor;
            this.abilityContainer2.IsVacant = true;
            this.abilityContainer2.Location = new System.Drawing.Point(373, 370);
            this.abilityContainer2.Name = "abilityContainer2";
            this.abilityContainer2.Size = new System.Drawing.Size(170, 124);
            this.abilityContainer2.TabIndex = 17;
            // 
            // abilityContainer1
            // 
            this.abilityContainer1.Ability = null;
            this.abilityContainer1.AllowDrop = true;
            this.abilityContainer1.BackColor = AbilityCardContainerStyle.BackColor;
            this.abilityContainer1.IsVacant = true;
            this.abilityContainer1.Location = new System.Drawing.Point(196, 370);
            this.abilityContainer1.Name = "abilityContainer1";
            this.abilityContainer1.Size = new System.Drawing.Size(170, 124);
            this.abilityContainer1.TabIndex = 16;
            // 
            // abilityCard1
            // 
            this.abilityCard1.Ability = null;
            this.abilityCard1.AbilityName = "NAME";
            this.abilityCard1.AllowDrop = true;
            this.abilityCard1.BackColor = AbilityCardStyle.BackColor;
            this.abilityCard1.CastTime = 0;
            this.abilityCard1.CoolDown = 0;
            this.abilityCard1.Description = "Description\r\nabout the spell";
            this.abilityCard1.DropAllowed = false;
            this.abilityCard1.IsHighlighted = false;
            this.abilityCard1.IsSelectable = true;
            this.abilityCard1.IsSelected = false;
            this.abilityCard1.IsVacant = false;
            this.abilityCard1.Location = new System.Drawing.Point(20, 151);
            this.abilityCard1.ManaCost = 0;
            this.abilityCard1.Name = "abilityCard1";
            this.abilityCard1.IsOffensive = false;
            this.abilityCard1.ParentContainer = null;
            this.abilityCard1.Size = new System.Drawing.Size(154, 104);
            this.abilityCard1.TabIndex = 15;
            // 
            // monsterIcon
            // 
            this.monsterIcon.BackColor = IconStyle.BackColor;
            this.monsterIcon.Character = null;
            this.monsterIcon.CharacterName = "0";
            this.monsterIcon.IconColor = IconStyle.IconColor;
            this.monsterIcon.Image = null;
            this.monsterIcon.IsHighlighted = false;
            this.monsterIcon.IsLocked = false;
            this.monsterIcon.IsSelectable = true;
            this.monsterIcon.IsSelected = false;
            this.monsterIcon.Level = 0;
            this.monsterIcon.Location = new System.Drawing.Point(630, 13);
            this.monsterIcon.Name = "monsterIcon";
            this.monsterIcon.Size = new System.Drawing.Size(250, 54);
            this.monsterIcon.TabIndex = 4;
            // 
            // playerIcon
            // 
            this.playerIcon.BackColor = IconStyle.BackColor;
            this.playerIcon.Character = null;
            this.playerIcon.CharacterName = "0";
            this.playerIcon.IconColor = IconStyle.IconColor;
            this.playerIcon.Image = null;
            this.playerIcon.IsHighlighted = false;
            this.playerIcon.IsLocked = false;
            this.playerIcon.IsSelectable = true;
            this.playerIcon.IsSelected = false;
            this.playerIcon.Level = 0;
            this.playerIcon.Location = new System.Drawing.Point(20, 13);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(250, 54);
            this.playerIcon.TabIndex = 2;
            // 
            // GamePlayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = FormStyle.BackColor;
            this.Controls.Add(this.abilityCardMonster);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.monsterHealthBar);
            this.Controls.Add(this.playerManaBar);
            this.Controls.Add(this.abilityCard10);
            this.Controls.Add(this.abilityCard5);
            this.Controls.Add(this.abilityCard9);
            this.Controls.Add(this.abilityCard4);
            this.Controls.Add(this.abilityCard8);
            this.Controls.Add(this.abilityCard3);
            this.Controls.Add(this.abilityCard7);
            this.Controls.Add(this.abilityCard2);
            this.Controls.Add(this.abilityCard6);
            this.Controls.Add(this.abilityContainer3);
            this.Controls.Add(this.abilityContainer2);
            this.Controls.Add(this.abilityContainer1);
            this.Controls.Add(this.abilityCard1);
            this.Controls.Add(this.buttonFinishRound);
            this.Controls.Add(this.monsterIcon);
            this.Controls.Add(this.playerIcon);
            this.Name = "GamePlayControl";
            this.Size = new System.Drawing.Size(900, 507);
            this.ResumeLayout(false);

        }

        #endregion

        private CharacterIcon playerIcon;
        private CharacterIcon monsterIcon;
        private System.Windows.Forms.Button buttonFinishRound;
        private AbilityCard abilityCard1;
        private AbilityContainer abilityContainer1;
        private AbilityContainer abilityContainer2;
        private AbilityContainer abilityContainer3;
        private AbilityCard abilityCard6;
        private AbilityCard abilityCard2;
        private AbilityCard abilityCard7;
        private AbilityCard abilityCard3;
        private AbilityCard abilityCard8;
        private AbilityCard abilityCard4;
        private AbilityCard abilityCard9;
        private AbilityCard abilityCard5;
        private AbilityCard abilityCard10;
        private SmoothProgressBar.SmoothProgressBar playerManaBar;
        private SmoothProgressBar.SmoothProgressBar monsterHealthBar;
        private SmoothProgressBar.SmoothProgressBar playerHealthBar;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.ToolTip toolTipResource;
        private AbilityCard abilityCardMonster;

    }
}
