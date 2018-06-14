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
        private List<Image> imageList { get; set; }
        private int[] imagePositions { get; set; }
        private int spines { get; set; }
        private int lines { get; set; }
        private int linesWin { get; set; }
        private int lastWin { get; set; }
        public GamePlay()
        {
            InitializeComponent();
            imageList = new List<Image>();
            spines = 0;
            imagePositions = new int[9];
            linesWin = 0;
            lastWin = 0;
            lines = Convert.ToInt32(numLines.Value);
            
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            imageList.Add(Properties.Resources.strukturno);
            imageList.Add(Properties.Resources.objektno);
            imageList.Add(Properties.Resources.kalkulus);
            imageList.Add(Properties.Resources.diskretna);
            imageList.Add(Properties.Resources.algoritmi);
            imageList.Add(Properties.Resources.napredno);
            imageList.Add(Properties.Resources.verojatnost);
            imageList.Add(Properties.Resources.vestacka);
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
            if (spines >= 7)
            {
                spin(1);
                spines++;
                checkWin();
                return;
            }
            if (spines >= 13)
                spines = 0;
            spin();
            spines++;
            checkWin();
        }
        private void spin(int chance = 0)
        {
            if (chance == 0)
            {
                Random rand = new Random();
                for (int i = 0; i < 9; i++)
                {
                    imagePositions[i] = rand.Next(0, 8);
                }
                pictureBox1.Image = imageList[imagePositions[0]];
                pictureBox2.Image = imageList[imagePositions[1]];
                pictureBox3.Image = imageList[imagePositions[2]];
                pictureBox4.Image = imageList[imagePositions[3]];
                pictureBox5.Image = imageList[imagePositions[4]];
                pictureBox6.Image = imageList[imagePositions[5]];
                pictureBox7.Image = imageList[imagePositions[6]];
                pictureBox8.Image = imageList[imagePositions[7]];
                pictureBox9.Image = imageList[imagePositions[8]];

            }
            else if (chance == 1)
            {
                Random rand = new Random();
                for (int i = 0; i < 9; i++)
                {
                    imagePositions[i] = rand.Next(0, 4);
                }
                pictureBox1.Image = imageList[imagePositions[0]];
                pictureBox2.Image = imageList[imagePositions[1]];
                pictureBox3.Image = imageList[imagePositions[2]];
                pictureBox4.Image = imageList[imagePositions[3]];
                pictureBox5.Image = imageList[imagePositions[4]];
                pictureBox6.Image = imageList[imagePositions[5]];
                pictureBox7.Image = imageList[imagePositions[6]];
                pictureBox8.Image = imageList[imagePositions[7]];
                pictureBox9.Image = imageList[imagePositions[8]];
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkWin()
        {
            if(lines==1)
                if(imagePositions[0]==imagePositions[4] && imagePositions[0]==imagePositions[8])
                    {
                        linesWin++;
                    }
            if (lines == 2)
            {
                if (imagePositions[0] == imagePositions[4] && imagePositions[0] == imagePositions[8])
                {
                    linesWin++;
                }
                if (imagePositions[1] == imagePositions[4] && imagePositions[1] == imagePositions[7])
                {
                    linesWin++;
                }
            }
            if (lines == 3)
            {
                if (imagePositions[0] == imagePositions[4] && imagePositions[0] == imagePositions[8])
                {
                    linesWin++;
                }
                if (imagePositions[1] == imagePositions[4] && imagePositions[1] == imagePositions[7])
                {
                    linesWin++;
                }
                if (imagePositions[2] == imagePositions[4] && imagePositions[2] == imagePositions[6])
                {
                    linesWin++;
                }
            }
            if (lines == 4)
            {
                if (imagePositions[0] == imagePositions[4] && imagePositions[0] == imagePositions[8])
                {
                    linesWin++;
                }
                if (imagePositions[1] == imagePositions[4] && imagePositions[1] == imagePositions[7])
                {
                    linesWin++;
                }
                if (imagePositions[2] == imagePositions[4] && imagePositions[2] == imagePositions[6])
                {
                    linesWin++;
                }
                if (imagePositions[0] == imagePositions[3] && imagePositions[0] == imagePositions[6])
                {
                    linesWin++;
                }
            }
            if (lines == 5)
            {
                if (imagePositions[0] == imagePositions[4] && imagePositions[0] == imagePositions[8])
                {
                    linesWin++;
                }
                if (imagePositions[1] == imagePositions[4] && imagePositions[1] == imagePositions[7])
                {
                    linesWin++;
                }
                if (imagePositions[2] == imagePositions[4] && imagePositions[2] == imagePositions[6])
                {
                    linesWin++;
                }
                if (imagePositions[0] == imagePositions[3] && imagePositions[0] == imagePositions[6])
                {
                    linesWin++;
                }
                if (imagePositions[2] == imagePositions[5] && imagePositions[2] == imagePositions[8])
                {
                    linesWin++;
                }
            }
            lastWin = linesWin * 3;
            txtLastWin.Text = lastWin.ToString();
            linesWin = 0;
            
        }

        private void numLines_ValueChanged(object sender, EventArgs e)
        {
            lines = Convert.ToInt32(numLines.Value);

        }
    }
}
