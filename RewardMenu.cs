using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class RewardMenu : Form
    {
        private int _gold;

        public int Intellect { get; private set; }
        public int Spirit { get; private set; }
        public int MaxHealth { get; private set; }
        public int MaxMana { get; private set; }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                labelGold.Text = "Remaining Gold: " + _gold.ToString();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public RewardMenu(int gold)
        {
            InitializeComponent();
            Intellect = 0;
            Spirit = 0;
            MaxHealth = 0;
            MaxMana = 0;
            Gold = gold;

            makeUnavailable();
        }

        private void makeUnavailable()
        {
            if (Gold < 400) buttonHundredMaxMana.Enabled = false;
            if (Gold < 375) buttonTenSpirit.Enabled = false;
            if (Gold < 250) buttonHundredMaxHealth.Enabled = false;
            if (Gold < 200) buttonTenIntellect.Enabled = false;
            if (Gold < 50) buttonTenMaxMana.Enabled = false;
            if (Gold < 45) buttonOneSpirit.Enabled = false;
            if (Gold < 30) buttonTenMaxHealth.Enabled = false;
            if (Gold < 25) buttonOneIntellect.Enabled = false;
        }

        private void buttonOneIntellect_Click(object sender, EventArgs e)
        {
            Intellect += 1;
            Gold -= 25;
            makeUnavailable();
        }

        private void buttonTenIntellect_Click(object sender, EventArgs e)
        {
            Intellect += 10;
            Gold -= 200;
            makeUnavailable();
        }

        private void buttonOneSpirit_Click(object sender, EventArgs e)
        {
            Spirit += 1;
            Gold -= 45;
            makeUnavailable();
        }

        private void buttonTenSpirit_Click(object sender, EventArgs e)
        {
            Spirit += 10;
            Gold -= 375;
            makeUnavailable();
        }

        private void buttonTenMaxHealth_Click(object sender, EventArgs e)
        {
            MaxHealth += 10;
            Gold -= 30;
            makeUnavailable();
        }

        private void buttonHundredMaxHealth_Click(object sender, EventArgs e)
        {
            MaxHealth += 100;
            Gold -= 250;
            makeUnavailable();
        }

        private void buttonTenMaxMana_Click(object sender, EventArgs e)
        {
            MaxMana += 10;
            Gold -= 50;
            makeUnavailable();
        }

        private void buttonHundredMaxMana_Click(object sender, EventArgs e)
        {
            MaxMana += 100;
            Gold -= 400;
            makeUnavailable();
        }

        private void RewardMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
