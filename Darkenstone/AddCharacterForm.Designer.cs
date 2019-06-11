namespace Darkenstone
{
    partial class AddCharacterForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameValidation = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(69, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = ButtonStyle.BackColor;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Enabled = false;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOK.ForeColor = ButtonStyle.TextColor;
            this.buttonOK.Location = new System.Drawing.Point(21, 135);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 35);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = ButtonStyle.BackColor;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.ForeColor = ButtonStyle.TextColor;
            this.buttonCancel.Location = new System.Drawing.Point(178, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = LabelStyle.TransparentBackColor;
            this.labelName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = LabelStyle.TextColor;
            this.labelName.Location = new System.Drawing.Point(31, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(250, 24);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Choose icon and name";
            this.labelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddCharacter_MouseDown);
            // 
            // labelNameValidation
            // 
            this.labelNameValidation.AutoSize = true;
            this.labelNameValidation.BackColor = LabelStyle.TransparentBackColor;
            this.labelNameValidation.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameValidation.ForeColor = LabelStyle.TextColor;
            this.labelNameValidation.Location = new System.Drawing.Point(66, 44);
            this.labelNameValidation.Name = "labelNameValidation";
            this.labelNameValidation.Size = new System.Drawing.Size(224, 28);
            this.labelNameValidation.TabIndex = 7;
            this.labelNameValidation.Text = "Character name must be \r\nbetween 3 - 20 characters long!";
            this.labelNameValidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNameValidation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddCharacter_MouseDown);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = ColorDialogStyle.BackColor;
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = ButtonStyle.BackColor;
            this.buttonColor.Location = new System.Drawing.Point(21, 75);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(32, 32);
            this.buttonColor.TabIndex = 8;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // AddCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = FormStyle.BackColor;
            this.ClientSize = new System.Drawing.Size(314, 194);
            this.ControlBox = false;
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelNameValidation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddCharacter_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameValidation;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonColor;
    }
}