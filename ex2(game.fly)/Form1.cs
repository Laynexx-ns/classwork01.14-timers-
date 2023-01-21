using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_game.fly_
{
    public partial class Form1 : Form
    {

        int score = 0;
        int timeleft = 10;
        int activation = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(10, 590);
            int y = r.Next(10, 490);

            fly.Left = x;
            fly.Top = y;
        }

        private void fly_Click(object sender, EventArgs e)
        {
            if (activation == 0)
            {
                gametimer.Enabled = true;
                activation += 1;
            }
            #region fly.xy
            //random
            if (timeleft > 0)
            {
                Random r = new Random();
                int x = r.Next(10, 790);
                int y = r.Next(10, 490);

                fly.Left = x;
                fly.Top = y;
            }
            #endregion
            if (timeleft > 0)
            {
                score++; //it`s also like score += 1
                scorelabel.Text = "your score:" + score.ToString();
            }


                

        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            timeleft--; //it`s also like timeleft -= 1
            timelabel.Text = "time left:" + timeleft.ToString();

            if (timeleft == 0)
            {
                gametimer.Enabled = false;
            }
            if (score <10)
            {
                MessageBox.Show("bad");
            }
            else if (score <15)
            {
                MessageBox.Show("cool");
            }
            else
            {
                MessageBox.Show("very nice");
            }
        }
    }
}
