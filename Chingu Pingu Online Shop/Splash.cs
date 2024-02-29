using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chingu_Pingu_Online_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 4;
            Myprogress.Value = startpos;
            PercentageLbl.Text = startpos + "%";
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login form1 = new Login();
                form1.Show();
                this.Hide();
            }
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void PercentageLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
