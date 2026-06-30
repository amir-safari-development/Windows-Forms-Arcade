using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arcade_Game
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MenuForm game2 = new MenuForm();

            game2.Show();
            this.Hide();
        }

        private void NormMode_Click(object sender, EventArgs e)
        {
            MainForm game3 = new MainForm();

            game3.Show();
            this.Hide();
        }
    }
}
