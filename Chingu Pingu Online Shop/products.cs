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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chingu_Pingu_Online_Shop
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            String Product_name = BTitleTb.Text;
            String Made_in =    BMadeinTb.Text;
            String Catagories =  BcatCb.Text;
            String Quantity= BquaTb.Text;
            String price = BPriceTb.Text;


            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = DESKTOP-O7STVBH\\SQLEXPRESS; database =Chingupingu ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "insert into products(Product_name,Made_in,Catagories,Quantity,price) values('"+ Product_name + "','"+ Made_in + "','"+ Catagories + "','"+ Quantity + "','"+ price + "') ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            String Product_name = BTitleTb.Text;
            String Made_in = BMadeinTb.Text;
            String Catagories = BcatCb.Text;
            String Quantity = BquaTb.Text;
            String price = BPriceTb.Text;


            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = DESKTOP-O7STVBH\\SQLEXPRESS; database =Chingupingu ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Update products Set price ='" + price + "' where Product_name ='" + Product_name + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            String Product_name = BTitleTb.Text;
            String Made_in = BMadeinTb.Text;
            String Catagories = BcatCb.Text;
            String Quantity = BquaTb.Text;
            String price = BPriceTb.Text;


            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = DESKTOP-O7STVBH\\SQLEXPRESS; database =Chingupingu ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "delete from products where  Product_name ='" + Product_name + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AdminLogin adminLoginadmin = new AdminLogin();
            adminLoginadmin.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Gallary products = new Gallary();
            products.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
