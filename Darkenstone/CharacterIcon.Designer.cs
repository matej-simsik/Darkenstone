namespace Darkenstone
{
    partial class CharacterIcon
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
            this.panelIcon = new System.Windows.Forms.Panel();
            this.panelCharName = new System.Windows.Forms.Panel();
            this.labelCharName = new System.Windows.Forms.Label();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.labelLevel = new System.Windows.Forms.Label();
            this.toolTipDetails = new System.Windows.Forms.ToolTip(this.components);
            this.panelCharName.SuspendLayout();
            this.panelLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIcon
            // 
            this.panelIcon.Location = new System.Drawing.Point(2, 2);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(50, 50);
            this.panelIcon.TabIndex = 0;
            this.panelIcon.Click += new System.EventHandler(this.mouseClick);
            this.panelIcon.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.panelIcon.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // panelCharName
            // 
            this.panelCharName.BackColor = PanelStyle.BackColor;
            this.panelCharName.Controls.Add(this.labelCharName);
            this.panelCharName.Location = new System.Drawing.Point(52, 2);
            this.panelCharName.Name = "panelCharName";
            this.panelCharName.Size = new System.Drawing.Size(146, 50);
            this.panelCharName.TabIndex = 1;
            this.panelCharName.Click += new System.EventHandler(this.mouseClick);
            this.panelCharName.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.panelCharName.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // labelCharName
            // 
            this.labelCharName.BackColor = LabelStyle.TransparentBackColor;
            this.labelCharName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCharName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCharName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCharName.ForeColor = LabelStyle.TextColor;
            this.labelCharName.Location = new System.Drawing.Point(0, 0);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(146, 50);
            this.labelCharName.TabIndex = 10;
            this.labelCharName.Text = "Character Name";
            this.labelCharName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCharName.Click += new System.EventHandler(this.mouseClick);
            this.labelCharName.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelCharName.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // panelLevel
            // 
            this.panelLevel.BackColor = PanelStyle.BackColor;
            this.panelLevel.Controls.Add(this.labelLevel);
            this.panelLevel.Location = new System.Drawing.Point(198, 2);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(50, 50);
            this.panelLevel.TabIndex = 2;
            // 
            // labelLevel
            // 
            this.labelLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLevel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevel.ForeColor = LabelStyle.TextColor;
            this.labelLevel.Location = new System.Drawing.Point(0, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(50, 50);
            this.labelLevel.TabIndex = 0;
            this.labelLevel.Text = "1";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLevel.Click += new System.EventHandler(this.mouseClick);
            this.labelLevel.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelLevel.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // toolTipDetails
            // 
            this.toolTipDetails.BackColor = ToolTipStyle.BackColor;
            this.toolTipDetails.ForeColor = ToolTipStyle.TextColor;
            // 
            // CharacterIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = IconStyle.BackColor;
            this.Controls.Add(this.panelLevel);
            this.Controls.Add(this.panelIcon);
            this.Controls.Add(this.panelCharName);
            this.Name = "CharacterIcon";
            this.Size = new System.Drawing.Size(250, 54);
            this.panelCharName.ResumeLayout(false);
            this.panelLevel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Panel panelCharName;
        private System.Windows.Forms.Label labelCharName;
        private System.Windows.Forms.Panel panelLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ToolTip toolTipDetails;
    }
}
