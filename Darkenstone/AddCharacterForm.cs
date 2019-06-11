using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class AddCharacterForm : Form
    {
        private OpponentChoiceMenu _parentControl;

        public string CharacterName { get; private set; }
        public Color IconColor
        {
            get { return buttonColor.BackColor; }
            set { buttonColor.BackColor = value; }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AddCharacterForm(OpponentChoiceMenu parentControl)
        {
            InitializeComponent();
            _parentControl = parentControl;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && buttonOK.Enabled)
            {
                buttonOK.PerformClick();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            CharacterName = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int amountOfCharacters = textBox1.Text.Length;

            if (_parentControl.doesCharacterNameExist(textBox1.Text))
            {
                labelNameValidation.Text = "Character with selected name " + Environment.NewLine +
                    "already exists!";
                labelNameValidation.Visible = true;
                buttonOK.Enabled = false;
            }
            else if (amountOfCharacters < 3 || amountOfCharacters > 20)
            {
                labelNameValidation.Text = "Character name must be " + Environment.NewLine +
                    "between 3 - 20 characters long!";
                labelNameValidation.Visible = true;
                buttonOK.Enabled = false;
            }
            else
            {
                labelNameValidation.Visible = false;
                buttonOK.Enabled = true;
            }
        }

        private void AddCharacter_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (IconColor != null) colorDialog.Color = IconColor;
            var result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                IconColor = colorDialog.Color;
            }
        }
    }
}
