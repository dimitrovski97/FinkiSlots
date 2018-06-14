using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinkiSlots
{
    public partial class FinkiSlots : Form
    {
        public FinkiSlots()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // metod za pozicioniranje na aplikacijata so maus prevzemen od https://stackoverflow.com/questions/23966253/moving-form-without-title-bar
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules dialog = new Rules();
            dialog.ShowDialog(this);
            dialog.Dispose();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GamePlay newGame = new GamePlay();
            this.Hide();
            newGame.ShowDialog(this);
            newGame.Dispose();
            this.Show();
        }
    }
}
