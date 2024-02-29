using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chingu_Pingu_Online_Shop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = DESKTOP-O7STVBH\\SQLEXPRESS; database =Chingupingu ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Select * from products ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String name = BTitleTb.Text;
            Int64 quentity = Int64.Parse(BMadeinTb.Text);
            Int64 price = 0;
            String a = "___________";
            if(name== "LipStick")
            {
                price = quentity * 450;
                label2.Text = price.ToString();
            }
            else if (name == "Facewash")
            {
                price = quentity * 550;
                label2.Text = price.ToString();
            }
            else if (name == "Shower_Gel")
            {
                price = quentity * 690;
                label2.Text = price.ToString();
            }
            else if (name == "Handcream")
            {
                price = quentity * 170;
                label2.Text = price.ToString();
            }
            else if (name == "Body_Scrub")
            {
                price = quentity * 650;
                label2.Text = price.ToString();
            }
            else if (name == "Sakura-Serum")
            {
                price = quentity * 200;
                label2.Text = price.ToString();
            }
            else if (name == "Machacream")
            {
                price = quentity * 270;
                label2.Text = price.ToString();
            }
            else if (name == "Perfum")
            {
                price = quentity * 270;
                label2.Text = price.ToString();
            }
            else
            {
                label2.Text = a.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
