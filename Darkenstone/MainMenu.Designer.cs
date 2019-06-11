namespace Darkenstone
{
    partial class MainMenu
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
            this.labelNewGame = new System.Windows.Forms.Label();
            this.panelNewGame = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.panelExit = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.BackColor = System.Drawing.Color.Transparent;
            this.labelNewGame.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewGame.ForeColor = System.Drawing.Color.White;
            this.labelNewGame.Location = new System.Drawing.Point(433, 201);
            this.labelNewGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(294, 70);
            this.labelNewGame.TabIndex = 0;
            this.labelNewGame.Text = "New Game";
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            this.labelNewGame.MouseEnter += new System.EventHandler(this.labelNewGame_MouseEnter);
            this.labelNewGame.MouseLeave += new System.EventHandler(this.labelNewGame_MouseLeave);
            // 
            // panelNewGame
            // 
            this.panelNewGame.BackgroundImage = global::Darkenstone.Properties.Resources.amethystFinal;
            this.panelNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNewGame.Location = new System.Drawing.Point(351, 201);
            this.panelNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNewGame.Name = "panelNewGame";
            this.panelNewGame.Size = new System.Drawing.Size(75, 69);
            this.panelNewGame.TabIndex = 1;
            this.panelNewGame.Visible = false;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(481, 354);
            this.labelExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(162, 70);
            this.labelExit.TabIndex = 2;
            this.labelExit.Text = "Exit";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // panelExit
            // 
            this.panelExit.BackgroundImage = global::Darkenstone.Properties.Resources.amethystFinal;
            this.panelExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelExit.Location = new System.Drawing.Point(399, 354);
            this.panelExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(75, 69);
            this.panelExit.TabIndex = 2;
            this.panelExit.Visible = false;
            // 
            // MainMenu
            // 
            this.AccessibleName = "MainMenu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.panelNewGame);
            this.Controls.Add(this.labelNewGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(1200, 624);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.Panel panelNewGame;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Panel panelExit;
    }
}
