using System;
using System.Windows.Forms;

namespace ServiceMocker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clearTokenListButton_Click(object sender, EventArgs e)
        {
            allowedTokensCheckedListBox.Items.Clear();
        }
    }
}
