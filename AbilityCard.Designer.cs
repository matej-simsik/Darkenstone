namespace Darkenstone
{
    partial class AbilityCard
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
            this.panelOffensive = new System.Windows.Forms.Panel();
            this.panelManaCost = new System.Windows.Forms.Panel();
            this.labelManaCost = new System.Windows.Forms.Label();
            this.panelCoolDown = new System.Windows.Forms.Panel();
            this.labelCoolDown = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelCover = new System.Windows.Forms.Panel();
            this.toolTipCoolDown = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOffensive = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipManaCost = new System.Windows.Forms.ToolTip(this.components);
            this.panelCastTime = new System.Windows.Forms.Panel();
            this.labelCastTime = new System.Windows.Forms.Label();
            this.toolTipCastTime = new System.Windows.Forms.ToolTip(this.components);
            this.panelManaCost.SuspendLayout();
            this.panelCoolDown.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.panelCastTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOffensive
            // 
            this.panelOffensive.AllowDrop = true;
            this.panelOffensive.BackColor = PanelStyle.BackColor;
            this.panelOffensive.Location = new System.Drawing.Point(3, 33);
            this.panelOffensive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOffensive.Name = "panelOffensive";
            this.panelOffensive.Size = new System.Drawing.Size(67, 31);
            this.panelOffensive.TabIndex = 1;
            this.panelOffensive.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.panelOffensive.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.panelOffensive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panelOffensive.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.panelOffensive.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // panelManaCost
            // 
            this.panelManaCost.BackColor = PanelStyle.BackColor;
            this.panelManaCost.Controls.Add(this.labelManaCost);
            this.panelManaCost.Location = new System.Drawing.Point(3, 64);
            this.panelManaCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelManaCost.Name = "panelManaCost";
            this.panelManaCost.Size = new System.Drawing.Size(67, 31);
            this.panelManaCost.TabIndex = 2;
            // 
            // labelManaCost
            // 
            this.labelManaCost.AllowDrop = true;
            this.labelManaCost.BackColor = ResourceStyle.ManaColor;
            this.labelManaCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelManaCost.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManaCost.ForeColor = LabelStyle.TextColor;
            this.labelManaCost.Location = new System.Drawing.Point(0, 0);
            this.labelManaCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManaCost.Name = "labelManaCost";
            this.labelManaCost.Size = new System.Drawing.Size(67, 31);
            this.labelManaCost.TabIndex = 0;
            this.labelManaCost.Text = "0";
            this.labelManaCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelManaCost.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.labelManaCost.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.labelManaCost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.labelManaCost.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelManaCost.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // panelCoolDown
            // 
            this.panelCoolDown.Controls.Add(this.labelCoolDown);
            this.panelCoolDown.Location = new System.Drawing.Point(3, 95);
            this.panelCoolDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCoolDown.Name = "panelCoolDown";
            this.panelCoolDown.Size = new System.Drawing.Size(33, 30);
            this.panelCoolDown.TabIndex = 3;
            // 
            // labelCoolDown
            // 
            this.labelCoolDown.AllowDrop = true;
            this.labelCoolDown.BackColor = LabelStyle.BackColor;
            this.labelCoolDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCoolDown.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCoolDown.ForeColor = LabelStyle.TextColor;
            this.labelCoolDown.Location = new System.Drawing.Point(0, 0);
            this.labelCoolDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoolDown.Name = "labelCoolDown";
            this.labelCoolDown.Size = new System.Drawing.Size(33, 30);
            this.labelCoolDown.TabIndex = 0;
            this.labelCoolDown.Text = "0";
            this.labelCoolDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCoolDown.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.labelCoolDown.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.labelCoolDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.labelCoolDown.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelCoolDown.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // panelName
            // 
            this.panelName.BackColor = PanelStyle.BackColor;
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Location = new System.Drawing.Point(3, 2);
            this.panelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(200, 31);
            this.panelName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AllowDrop = true;
            this.labelName.BackColor = LabelStyle.BackColor;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = LabelStyle.TextColor;
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(200, 31);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "NAME";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.labelName.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.labelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.labelName.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = PanelStyle.BackColor;
            this.panelDescription.Controls.Add(this.labelDescription);
            this.panelDescription.Location = new System.Drawing.Point(69, 33);
            this.panelDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(133, 92);
            this.panelDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AllowDrop = true;
            this.labelDescription.BackColor = LabelStyle.BackColor;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.ForeColor = LabelStyle.TextColor;
            this.labelDescription.Location = new System.Drawing.Point(0, 0);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(133, 92);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description\r\nabout the spell";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescription.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.labelDescription.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.labelDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.labelDescription.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelDescription.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // panelCover
            // 
            this.panelCover.AllowDrop = true;
            this.panelCover.BackColor = PanelStyle.BackColor;
            this.panelCover.Location = new System.Drawing.Point(3, 2);
            this.panelCover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(200, 123);
            this.panelCover.TabIndex = 6;
            this.panelCover.Visible = false;
            this.panelCover.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.panelCover.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // toolTipCoolDown
            // 
            this.toolTipCoolDown.BackColor = ToolTipStyle.BackColor;
            this.toolTipCoolDown.ForeColor = ToolTipStyle.TextColor;
            this.toolTipCoolDown.Tag = "";
            // 
            // toolTipOffensive
            // 
            this.toolTipOffensive.BackColor = ToolTipStyle.BackColor;
            this.toolTipOffensive.ForeColor = ToolTipStyle.TextColor;
            // 
            // toolTipManaCost
            // 
            this.toolTipManaCost.BackColor = ToolTipStyle.BackColor;
            this.toolTipManaCost.ForeColor = ToolTipStyle.TextColor;
            // 
            // panelCastTime
            // 
            this.panelCastTime.AllowDrop = true;
            this.panelCastTime.BackColor = PanelStyle.BackColor;
            this.panelCastTime.Controls.Add(this.labelCastTime);
            this.panelCastTime.Location = new System.Drawing.Point(36, 95);
            this.panelCastTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCastTime.Name = "panelCastTime";
            this.panelCastTime.Size = new System.Drawing.Size(33, 30);
            this.panelCastTime.TabIndex = 6;
            // 
            // labelCastTime
            // 
            this.labelCastTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCastTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCastTime.ForeColor = LabelStyle.TextColor;
            this.labelCastTime.Location = new System.Drawing.Point(0, 0);
            this.labelCastTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCastTime.Name = "labelCastTime";
            this.labelCastTime.Size = new System.Drawing.Size(33, 30);
            this.labelCastTime.TabIndex = 0;
            this.labelCastTime.Text = "0";
            this.labelCastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCastTime.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.labelCastTime.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // toolTipCastTime
            // 
            this.toolTipCastTime.BackColor = ToolTipStyle.BackColor;
            this.toolTipCastTime.ForeColor = ToolTipStyle.TextColor;
            // 
            // AbilityCard
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AbilityCardStyle.BackColor;
            this.Controls.Add(this.panelCover);
            this.Controls.Add(this.panelCastTime);
            this.Controls.Add(this.panelCoolDown);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.panelManaCost);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.panelOffensive);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AbilityCard";
            this.Size = new System.Drawing.Size(205, 128);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.panelManaCost.ResumeLayout(false);
            this.panelCoolDown.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.panelCastTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOffensive;
        private System.Windows.Forms.Panel panelManaCost;
        private System.Windows.Forms.Panel panelCoolDown;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Label labelManaCost;
        private System.Windows.Forms.Label labelCoolDown;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panelCover;
        private System.Windows.Forms.ToolTip toolTipCoolDown;
        private System.Windows.Forms.ToolTip toolTipOffensive;
        private System.Windows.Forms.ToolTip toolTipManaCost;
        private System.Windows.Forms.Panel panelCastTime;
        private System.Windows.Forms.Label labelCastTime;
        private System.Windows.Forms.ToolTip toolTipCastTime;
    }
}
