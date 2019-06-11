namespace Darkenstone
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenu1 = new Darkenstone.MainMenu();
            this.opponentChoiceMenu1 = new Darkenstone.OpponentChoiceMenu();
            this.gamePlayControl1 = new Darkenstone.GamePlayControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainMenu1);
            this.panel1.Controls.Add(this.opponentChoiceMenu1);
            this.panel1.Controls.Add(this.gamePlayControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 507);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // mainMenu1
            // 
            this.mainMenu1.AccessibleName = "MainMenu";
            this.mainMenu1.BackColor = FormStyle.BackColor;
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.MainForm = null;
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(900, 507);
            this.mainMenu1.TabIndex = 0;
            this.mainMenu1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // opponentChoiceMenu1
            // 
            this.opponentChoiceMenu1.BackColor = FormStyle.BackColor;
            this.opponentChoiceMenu1.Location = new System.Drawing.Point(0, 0);
            this.opponentChoiceMenu1.MainForm = null;
            this.opponentChoiceMenu1.Name = "opponentChoiceMenu1";
            this.opponentChoiceMenu1.Size = new System.Drawing.Size(900, 507);
            this.opponentChoiceMenu1.TabIndex = 1;
            this.opponentChoiceMenu1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // gamePlayControl1
            // 
            this.gamePlayControl1.BackColor = FormStyle.BackColor;
            this.gamePlayControl1.Location = new System.Drawing.Point(0, 0);
            this.gamePlayControl1.MainForm = null;
            this.gamePlayControl1.Name = "gamePlayControl1";
            this.gamePlayControl1.Size = new System.Drawing.Size(900, 507);
            this.gamePlayControl1.TabIndex = 2;
            this.gamePlayControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 507);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MainMenu mainMenu1;
        private OpponentChoiceMenu opponentChoiceMenu1;
        private GamePlayControl gamePlayControl1;
    }
}

