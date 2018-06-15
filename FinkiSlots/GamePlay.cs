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
        private int lastWin { get; set; }
        private int coefficient { get; set; }
        private int balance { get; set; }
        private int bet { get; set; }
        private int timerCounter { get; set; }
        public bool jackPot { get; set; }

        public GamePlay()
        {
            InitializeComponent();
            imageList = new List<Image>();
            spines = 0;
            imagePositions = new int[9];
            lastWin = 0;
            lines = Convert.ToInt32(numLines.Value);
            coefficient = 1;
            balance = 30;
            txtBalance.Text = balance.ToString();
            bet = Convert.ToInt32(numBet.Value);
            timerCounter = 10;
            jackPot = false;

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
            if (!spinAllowed())
            {
                MessageBox.Show("Not enough. Insert coins please");
                return;
            }
            timerCounter = 10;
            timer1.Start();        

        }
        private void spin(int chance = 0)
        {
            this.Refresh();
            if (balance == 228)
            {
                for (int i = 0; i < 9; i++)
                {
                    imagePositions[i] = 6;
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
                return;
            }
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
            if (checkJackpot() == true)
            {
                updateBalance();
                txtLastWin.Text = "JACKPOT";
                DrawLines(1);
                DrawLines(2);
                DrawLines(3);
                DrawLines(4);
                DrawLines(5);
                return;

            }
            
            if (lines==1)
                if(imagePositions[0]==imagePositions[3] && imagePositions[0]==imagePositions[6])
                    {
                        calculateCoefficient(imagePositions[0]);
                        DrawLines(1);
                }
            if (lines == 2)
            {
                if (imagePositions[0] == imagePositions[3] && imagePositions[0] == imagePositions[6])
                {
                    calculateCoefficient(imagePositions[0]);
                    DrawLines(1);
                }
                if (imagePositions[1] == imagePositions[4] && imagePositions[1] == imagePositions[7])
                {
                    calculateCoefficient(imagePositions[1]);
                    DrawLines(2);
                }
            }
            if (lines == 3)
            {
                if (imagePositions[0] == imagePositions[3] && imagePositions[0] == imagePositions[6])
                {
                    calculateCoefficient(imagePositions[0]);
                    DrawLines(1);
                }
                if (imagePositions[1] == imagePositions[4] && imagePositions[1] == imagePositions[7])
                {
                    calculateCoefficient(imagePositions[1]);
                    DrawLines(2);
                }
                if (imagePositions[2] == imagePositions[5] && imagePositions[2] == imagePositions[8])
                {
                    calculateCoefficient(imagePositions[2]);
                    DrawLines(3);
                }
            }
            if (lines == 4)
            {
                if (imagePositions[0] == imagePositions[3] && imagePositions[0] == imagePositions[6])
                {
                    calculateCoefficient(imagePositions[0]);
                    DrawLines(1);
                }
                if (imagePositions[1] == imagePositions[4] && imagePositions[1] == imagePositions[7])
                {
                    calculateCoefficient(imagePositions[1]);
                    DrawLines(2);
                }
                if (imagePositions[2] == imagePositions[5] && imagePositions[2] == imagePositions[8])
                {
                    calculateCoefficient(imagePositions[2]);
                    DrawLines(3);
                }
                if (imagePositions[0] == imagePositions[4] && imagePositions[0] == imagePositions[8])
                {
                    calculateCoefficient(imagePositions[0]);
                    DrawLines(4);
                }
            }
            if (lines == 5)
            {
                if (imagePositions[0] == imagePositions[3] && imagePositions[0] == imagePositions[6])
                {
                    calculateCoefficient(imagePositions[0]);
                    DrawLines(1);
                }
                if (imagePositions[1] == imagePositions[4] && imagePositions[1] == imagePositions[7])
                {
                    calculateCoefficient(imagePositions[1]);
                    DrawLines(2);
                }
                if (imagePositions[2] == imagePositions[5] && imagePositions[2] == imagePositions[8])
                {
                    calculateCoefficient(imagePositions[2]);
                    DrawLines(3);
                }
                if (imagePositions[0] == imagePositions[4] && imagePositions[0] == imagePositions[8])
                {
                    calculateCoefficient(imagePositions[0]);
                    DrawLines(4);
                }
                if (imagePositions[2] == imagePositions[4] && imagePositions[2] == imagePositions[6])
                {
                    calculateCoefficient(imagePositions[2]);
                    DrawLines(5);
                }
            }
            updateLastWin();
            updateBalance();
        }

        public bool checkJackpot()
        {            
            for (int i = 0; i < 9; i++)
            {
                if (imagePositions[i] != 6)
                    return false;
            }
            jackPot = true;
            return true;
        }

        public void DrawLines(int combination)
        {
            int rectangleWidth = pictureBox1.Width + 8;
            int rectangleHeight = pictureBox1.Height + 8;
            Graphics graphics = this.CreateGraphics();
            if (combination == 1)
            {
                Point startPoint = new Point();
                Point endPoint = new Point();
                startPoint.X = pictureBox1.Location.X + pictureBox1.Width / 3;
                startPoint.Y = pictureBox1.Location.Y + pictureBox1.Height / 2;                
                endPoint.X = pictureBox7.Location.X + pictureBox7.Width / 3 * 2;
                endPoint.Y = pictureBox7.Location.Y + pictureBox7.Height / 2;
                Pen p = new Pen(Color.Red);
                Brush b = new SolidBrush(Color.Red);
                p.Width = 10;
                graphics.DrawLine(p, startPoint, endPoint);
                graphics.FillRectangle(b, pictureBox1.Location.X - 4, pictureBox1.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox4.Location.X - 4, pictureBox4.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox7.Location.X - 4, pictureBox7.Location.Y - 4, rectangleWidth, rectangleHeight);
                p.Dispose();
                b.Dispose();
                graphics.Dispose();
            }
            if (combination == 2)
            {
                Point startPoint = new Point();
                Point endPoint = new Point();
                startPoint.X = pictureBox2.Location.X + pictureBox2.Width / 3;
                startPoint.Y = pictureBox2.Location.Y + pictureBox2.Height / 2;
                endPoint.X = pictureBox8.Location.X + pictureBox8.Width / 3 * 2;
                endPoint.Y = pictureBox8.Location.Y + pictureBox8.Height / 2;
                Pen p = new Pen(Color.Red);
                Brush b = new SolidBrush(Color.Red);
                p.Width = 10;
                graphics.DrawLine(p, startPoint, endPoint);
                graphics.DrawLine(p, startPoint, endPoint);
                graphics.FillRectangle(b, pictureBox2.Location.X - 4, pictureBox2.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox5.Location.X - 4, pictureBox5.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox8.Location.X - 4, pictureBox8.Location.Y - 4, rectangleWidth, rectangleHeight);

                graphics.Dispose();
                p.Dispose();
            }
            if (combination == 3)
            {
                Point startPoint = new Point();
                Point endPoint = new Point();
                startPoint.X = pictureBox3.Location.X + pictureBox3.Width / 3;
                startPoint.Y = pictureBox3.Location.Y + pictureBox3.Height / 2;
                endPoint.X = pictureBox9.Location.X + pictureBox9.Width / 3 * 2;
                endPoint.Y = pictureBox9.Location.Y + pictureBox9.Height / 2;
                Pen p = new Pen(Color.Red);
                Brush b = new SolidBrush(Color.Red);
                p.Width = 10;
                graphics.DrawLine(p, startPoint, endPoint);
                graphics.DrawLine(p, startPoint, endPoint);
                graphics.FillRectangle(b, pictureBox3.Location.X - 4, pictureBox3.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox6.Location.X - 4, pictureBox6.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox9.Location.X - 4, pictureBox9.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.Dispose();
                b.Dispose();
                p.Dispose();
            }
            if (combination == 4)
            {
                Point startPoint = new Point();
                Point endPoint = new Point();
                startPoint.X = pictureBox1.Location.X + pictureBox1.Width / 3;
                startPoint.Y = pictureBox1.Location.Y + pictureBox1.Height / 2;
                endPoint.X = pictureBox9.Location.X + pictureBox9.Width / 3 * 2;
                endPoint.Y = pictureBox9.Location.Y + pictureBox9.Height / 2;

                Pen p = new Pen(Color.Red);
                Brush b = new SolidBrush(Color.Red);
                p.Width = 10;
                graphics.DrawLine(p, startPoint, endPoint);
                graphics.FillRectangle(b, pictureBox1.Location.X - 4, pictureBox1.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox5.Location.X - 4, pictureBox5.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox9.Location.X - 4, pictureBox9.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.Dispose();
                b.Dispose();
                p.Dispose();
            }
            if (combination == 5)
            {
                Point startPoint = new Point();
                Point endPoint = new Point();
                startPoint.X = pictureBox3.Location.X + pictureBox3.Width / 3;
                startPoint.Y = pictureBox3.Location.Y + pictureBox3.Height / 2;
                endPoint.X = pictureBox7.Location.X + pictureBox7.Width / 3 * 2;
                endPoint.Y = pictureBox7.Location.Y + pictureBox7.Height / 2;
                Pen p = new Pen(Color.Red);
                Brush b = new SolidBrush(Color.Red);
                p.Width = 10;
                graphics.DrawLine(p, startPoint, endPoint);
                graphics.FillRectangle(b, pictureBox3.Location.X - 4, pictureBox3.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox5.Location.X - 4, pictureBox5.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.FillRectangle(b, pictureBox7.Location.X - 4, pictureBox7.Location.Y - 4, rectangleWidth, rectangleHeight);
                graphics.Dispose();
                p.Dispose();
            }
            
        }
        private void calculateCoefficient(int subject)
        {
            if (subject == 0 || subject == 1)
                coefficient = coefficient * 3;
            if (subject == 2 || subject == 3 || subject == 7)
                coefficient = coefficient * 4;
            if (subject == 4 || subject == 5 || subject == 8)
                coefficient = coefficient * 5;
            if (subject == 6 )
                coefficient = coefficient * 6;
        }
        private bool spinAllowed()
        {
            if (balance < bet * lines)
                return false;
            return true;
        }
        private void updateLastWin()
        {
            lastWin = bet * coefficient;
            if (lastWin == bet)
            {
                lastWin = 0;
            }
            txtLastWin.Text = lastWin.ToString();
            coefficient = 1;
        }
        private void updateBalance()
        {
            balance = (balance - bet * lines) + lastWin;
            txtBalance.Text = balance.ToString();
            if (balance != 0)
                numBet.Maximum = balance;
        }

        private void numLines_ValueChanged(object sender, EventArgs e)
        {
            lines = Convert.ToInt32(numLines.Value);

        }

        private void numBet_ValueChanged(object sender, EventArgs e)
        {
            bet = Convert.ToInt32(numBet.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spin();
            timerCounter--;
            if (timerCounter == 0)
            {
                timer1.Stop();
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
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertCoins newCoins = new InsertCoins();
            newCoins.lastBalance = balance;
            if (newCoins.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                balance = newCoins.lastBalance+1;
                updateBalance();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CashOut newCashOut = new CashOut();
            newCashOut.wonMoney = balance;
            newCashOut.wonJackpot = jackPot;
            if (newCashOut.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.Close();
        }
    }
}
