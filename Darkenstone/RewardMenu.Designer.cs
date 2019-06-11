namespace Darkenstone
{
    partial class RewardMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonOneIntellect = new System.Windows.Forms.Button();
            this.buttonTenIntellect = new System.Windows.Forms.Button();
            this.labelGold = new System.Windows.Forms.Label();
            this.buttonOneSpirit = new System.Windows.Forms.Button();
            this.buttonTenSpirit = new System.Windows.Forms.Button();
            this.buttonTenMaxHealth = new System.Windows.Forms.Button();
            this.buttonHundredMaxHealth = new System.Windows.Forms.Button();
            this.buttonTenMaxMana = new System.Windows.Forms.Button();
            this.buttonHundredMaxMana = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = LabelStyle.TextColor;
            this.labelName.Location = new System.Drawing.Point(118, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(162, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Choose Rewards";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = ButtonStyle.BackColor;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOK.ForeColor = ButtonStyle.TextColor;
            this.buttonOK.Location = new System.Drawing.Point(64, 216);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 35);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // buttonOneIntellect
            // 
            this.buttonOneIntellect.BackColor = LightButtonStyle.BackColor;
            this.buttonOneIntellect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOneIntellect.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOneIntellect.ForeColor = LightButtonStyle.TextColor;
            this.buttonOneIntellect.Location = new System.Drawing.Point(12, 64);
            this.buttonOneIntellect.Name = "buttonOneIntellect";
            this.buttonOneIntellect.Size = new System.Drawing.Size(187, 31);
            this.buttonOneIntellect.TabIndex = 4;
            this.buttonOneIntellect.Text = "1 Intellect for 25 gold";
            this.buttonOneIntellect.UseVisualStyleBackColor = false;
            this.buttonOneIntellect.Click += new System.EventHandler(this.buttonOneIntellect_Click);
            // 
            // buttonTenIntellect
            // 
            this.buttonTenIntellect.BackColor = LightButtonStyle.BackColor;
            this.buttonTenIntellect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTenIntellect.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTenIntellect.ForeColor = LightButtonStyle.TextColor;
            this.buttonTenIntellect.Location = new System.Drawing.Point(205, 64);
            this.buttonTenIntellect.Name = "buttonTenIntellect";
            this.buttonTenIntellect.Size = new System.Drawing.Size(187, 31);
            this.buttonTenIntellect.TabIndex = 5;
            this.buttonTenIntellect.Text = "10 Intellect for 200 gold";
            this.buttonTenIntellect.UseVisualStyleBackColor = false;
            this.buttonTenIntellect.Click += new System.EventHandler(this.buttonTenIntellect_Click);
            // 
            // labelGold
            // 
            this.labelGold.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGold.ForeColor = LabelStyle.TextColor;
            this.labelGold.Location = new System.Drawing.Point(123, 38);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(150, 23);
            this.labelGold.TabIndex = 6;
            this.labelGold.Text = "Remaining Gold: ";
            this.labelGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOneSpirit
            // 
            this.buttonOneSpirit.BackColor = LightButtonStyle.BackColor;
            this.buttonOneSpirit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOneSpirit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOneSpirit.ForeColor = LightButtonStyle.TextColor;
            this.buttonOneSpirit.Location = new System.Drawing.Point(12, 101);
            this.buttonOneSpirit.Name = "buttonOneSpirit";
            this.buttonOneSpirit.Size = new System.Drawing.Size(187, 31);
            this.buttonOneSpirit.TabIndex = 7;
            this.buttonOneSpirit.Text = "1 Spirit for 45 gold";
            this.buttonOneSpirit.UseVisualStyleBackColor = false;
            this.buttonOneSpirit.Click += new System.EventHandler(this.buttonOneSpirit_Click);
            // 
            // buttonTenSpirit
            // 
            this.buttonTenSpirit.BackColor = LightButtonStyle.BackColor;
            this.buttonTenSpirit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTenSpirit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTenSpirit.ForeColor = LightButtonStyle.TextColor;
            this.buttonTenSpirit.Location = new System.Drawing.Point(205, 101);
            this.buttonTenSpirit.Name = "buttonTenSpirit";
            this.buttonTenSpirit.Size = new System.Drawing.Size(187, 31);
            this.buttonTenSpirit.TabIndex = 8;
            this.buttonTenSpirit.Text = "10 Spirit for 375 gold";
            this.buttonTenSpirit.UseVisualStyleBackColor = false;
            this.buttonTenSpirit.Click += new System.EventHandler(this.buttonTenSpirit_Click);
            // 
            // buttonTenMaxHealth
            // 
            this.buttonTenMaxHealth.BackColor = LightButtonStyle.BackColor;
            this.buttonTenMaxHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTenMaxHealth.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTenMaxHealth.ForeColor = LightButtonStyle.TextColor;
            this.buttonTenMaxHealth.Location = new System.Drawing.Point(12, 138);
            this.buttonTenMaxHealth.Name = "buttonTenMaxHealth";
            this.buttonTenMaxHealth.Size = new System.Drawing.Size(187, 31);
            this.buttonTenMaxHealth.TabIndex = 9;
            this.buttonTenMaxHealth.Text = "10 Max Health for 30 gold";
            this.buttonTenMaxHealth.UseVisualStyleBackColor = false;
            this.buttonTenMaxHealth.Click += new System.EventHandler(this.buttonTenMaxHealth_Click);
            // 
            // buttonHundredMaxHealth
            // 
            this.buttonHundredMaxHealth.BackColor = LightButtonStyle.BackColor;
            this.buttonHundredMaxHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHundredMaxHealth.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHundredMaxHealth.ForeColor = LightButtonStyle.TextColor;
            this.buttonHundredMaxHealth.Location = new System.Drawing.Point(205, 138);
            this.buttonHundredMaxHealth.Name = "buttonHundredMaxHealth";
            this.buttonHundredMaxHealth.Size = new System.Drawing.Size(187, 31);
            this.buttonHundredMaxHealth.TabIndex = 10;
            this.buttonHundredMaxHealth.Text = "100 Max Health for 250 gold";
            this.buttonHundredMaxHealth.UseVisualStyleBackColor = false;
            this.buttonHundredMaxHealth.Click += new System.EventHandler(this.buttonHundredMaxHealth_Click);
            // 
            // buttonTenMaxMana
            // 
            this.buttonTenMaxMana.BackColor = LightButtonStyle.BackColor;
            this.buttonTenMaxMana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTenMaxMana.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTenMaxMana.ForeColor = LightButtonStyle.TextColor;
            this.buttonTenMaxMana.Location = new System.Drawing.Point(12, 175);
            this.buttonTenMaxMana.Name = "buttonTenMaxMana";
            this.buttonTenMaxMana.Size = new System.Drawing.Size(187, 31);
            this.buttonTenMaxMana.TabIndex = 11;
            this.buttonTenMaxMana.Text = "10 Max Mana for 50 gold";
            this.buttonTenMaxMana.UseVisualStyleBackColor = false;
            this.buttonTenMaxMana.Click += new System.EventHandler(this.buttonTenMaxMana_Click);
            // 
            // buttonHundredMaxMana
            // 
            this.buttonHundredMaxMana.BackColor = LightButtonStyle.BackColor;
            this.buttonHundredMaxMana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHundredMaxMana.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHundredMaxMana.ForeColor = LightButtonStyle.TextColor;
            this.buttonHundredMaxMana.Location = new System.Drawing.Point(205, 175);
            this.buttonHundredMaxMana.Name = "buttonHundredMaxMana";
            this.buttonHundredMaxMana.Size = new System.Drawing.Size(187, 31);
            this.buttonHundredMaxMana.TabIndex = 12;
            this.buttonHundredMaxMana.Text = "100 Max Mana for 400 gold";
            this.buttonHundredMaxMana.UseVisualStyleBackColor = false;
            this.buttonHundredMaxMana.Click += new System.EventHandler(this.buttonHundredMaxMana_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = ButtonStyle.BackColor;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.ForeColor = ButtonStyle.TextColor;
            this.buttonCancel.Location = new System.Drawing.Point(227, 216);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // RewardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = FormStyle.BackColor;
            this.ClientSize = new System.Drawing.Size(401, 263);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonHundredMaxMana);
            this.Controls.Add(this.buttonTenMaxMana);
            this.Controls.Add(this.buttonHundredMaxHealth);
            this.Controls.Add(this.buttonTenMaxHealth);
            this.Controls.Add(this.buttonTenSpirit);
            this.Controls.Add(this.buttonOneSpirit);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.buttonTenIntellect);
            this.Controls.Add(this.buttonOneIntellect);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RewardMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RewardMenu_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonOneIntellect;
        private System.Windows.Forms.Button buttonTenIntellect;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Button buttonOneSpirit;
        private System.Windows.Forms.Button buttonTenSpirit;
        private System.Windows.Forms.Button buttonTenMaxHealth;
        private System.Windows.Forms.Button buttonHundredMaxHealth;
        private System.Windows.Forms.Button buttonTenMaxMana;
        private System.Windows.Forms.Button buttonHundredMaxMana;
        private System.Windows.Forms.Button buttonCancel;
    }
}