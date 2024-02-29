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
    public partial class Gallary : Form
    {
        public Gallary()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            products products = new products();
            products.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin= new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin= new AdminLogin();

            adminLogin.Show();
            this.Hide();
        }
    }
}
