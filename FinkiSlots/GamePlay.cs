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
    public partial class GamePlay : Form
    {
        public List<Image> imageList { get; set; }
        public GamePlay()
        {
            InitializeComponent();
            imageList = new List<Image>();
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            imageList.Add(Properties.Resources.algoritmi);
            imageList.Add(Properties.Resources.diskretna);
            imageList.Add(Properties.Resources.kalkulus);
            imageList.Add(Properties.Resources.napredno);
            imageList.Add(Properties.Resources.verojatnost);
            imageList.Add(Properties.Resources.vestacka);
            imageList.Add(Properties.Resources.strukturno);
            imageList.Add(Properties.Resources.objektno);
            imageList.Add(Properties.Resources.vizuelno);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            pictureBox1.Image = imageList[rand.Next(0, 8)];
            pictureBox2.Image = imageList[rand.Next(0, 8)];
            pictureBox3.Image = imageList[rand.Next(0, 8)];
            pictureBox4.Image = imageList[rand.Next(0, 8)];
            pictureBox5.Image = imageList[rand.Next(0, 8)];
            pictureBox6.Image = imageList[rand.Next(0, 8)];
            pictureBox7.Image = imageList[rand.Next(0, 8)];
            pictureBox8.Image = imageList[rand.Next(0, 8)];
            pictureBox9.Image = imageList[rand.Next(0, 8)];
        }
    }
}
