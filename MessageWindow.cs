using System;
using System.Windows.Forms;

namespace Darkenstone
{
    public partial class MessageWindow : Form
    {
        public MessageWindow(string message)
        {
            InitializeComponent();
            labelMessage.Text = message;
        }
    }
}
