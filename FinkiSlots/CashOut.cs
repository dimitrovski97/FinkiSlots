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
    public partial class CashOut : Form
    {
        public int wonMoney { get; set; }
        public bool wonJackpot { get; set; }
        public CashOut()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void CashOut_Load(object sender, EventArgs e)
        {
            if (wonJackpot)
            {
                label2.Text = wonMoney.ToString()+" JACKPOT";
            }
            else
                label2.Text = wonMoney.ToString();
        }
    }
}
