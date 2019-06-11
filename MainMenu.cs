using System;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class MainMenu : UserControl
    {
        private MainForm _mainForm;

        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; } }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void labelNewGame_Click(object sender, EventArgs e)
        {
            MainForm.ShowNextControl();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelNewGame_MouseEnter(object sender, EventArgs e)
        {
            panelNewGame.Visible = true;
        }

        private void labelNewGame_MouseLeave(object sender, EventArgs e)
        {
            panelNewGame.Visible = false;
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            panelExit.Visible = true;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            panelExit.Visible = false;
        }
    }
}
