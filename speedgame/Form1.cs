using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speedgame
{


    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void timercars_Tick(object sender, EventArgs e)
        {
            mazdarx7.Left = mazdarx7.Left + r.Next(0, 20);
            toyotaae86.Left = toyotaae86.Left + r.Next(0, 20);

            if (toyotaae86.Right >= buttonfinish.Right)
            {
                timercars.Enabled = false;
                MessageBox.Show("ae86 has won");
            }
            else if (mazdarx7.Right >= buttonfinish.Right)
            {
                timercars.Enabled = false;
                MessageBox.Show("rx7 has won!");
            }


        }

        private void toyotaae86_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timercars.Enabled = true;
        }
    }
}
