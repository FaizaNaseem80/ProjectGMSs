using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGMS
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            try
            {
                P.Proid= Convert.ToInt32(textBox1.Text);
                P.ProName = textBox2.Text;
                P. ProPrice= Convert.ToInt32(textBox3.Text);
                P.ProQTY = Convert.ToInt32(textBox4.Text);
                P.CateId = Convert.ToInt32(textBox5.Text);
                P.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Product P=new Product();
            DataTable dt = P.Read();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            try
            {
                P.Proid = Convert.ToInt32(textBox1.Text);
                P.ProName = textBox2.Text;
                P.ProPrice = Convert.ToInt32(textBox3.Text);
                P.ProQTY = Convert.ToInt32(textBox3.Text);
                P.CateId = Convert.ToInt32(textBox3.Text);
                P.Update();
               
    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            DataTable dt = P.Read();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            DataTable dt = P.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            DataTable dt = P.Delete();
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Category C = new Category();
            DataTable dt = C.Read();
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView2.CurrentCell.Value.ToString();
        }
    }
}
