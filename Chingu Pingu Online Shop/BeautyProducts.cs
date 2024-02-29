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
using System.Data.SqlClient;
namespace Chingu_Pingu_Online_Shop
{
    public partial class BeautyProducts : Form
    {
        public BeautyProducts()
        {
            InitializeComponent(); 
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\onlineshopdb.mdf;Integrated Security=True;Connect Timeout=30");
    //private void SaveBtn_Click(object sender, EventArgs e)
       /* {
            if (OTitleTb.Text == "" || OMadeinTb.Text == "" || OquaTb.Text == "" || OPriceTb.Text == "" || OCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                   // string query = "insert into BeautyProducttbl values('" + OTitleTb.Text + "','" + OMadeinTb.Text + "','" + OCatCb.SelectedIndex.ToString() + "'," + OquaTb.Text + "," + OPriceTb.Text + ")";
                   // SqlCommand cmd = new SqlCommand(query, Con);
                   // cmd.ExecuteNonQuery();
                    MessageBox.Show("BeautyProduct Saved Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }*/

       // }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BcatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BMadeinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            BeautyProducts form1= new BeautyProducts();
            form1.Show(); 
            this.Hide();    
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ChinguPinguUsers form1= new ChinguPinguUsers();       
            form1.Show();   
            this.Hide();    

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Dashboard form1= new Dashboard();       
            form1.Show();   
            this.Hide();    
        }
    }
}
