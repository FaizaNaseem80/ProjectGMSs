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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders o=new Orders();

            try
            {

                o.Orderid = Convert.ToInt32(textBox1.Text);
                o.Cusid= Convert.ToInt32(textBox2.Text);
                o.OrderDate = dateTimePicker1.Text;
                o.TotalAmount= Convert.ToInt32(textBox4.Text);


                o.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders o = new Orders();

            try
            {

                o.Orderid = Convert.ToInt32(textBox1.Text);
                o.Cusid = Convert.ToInt32(textBox2.Text);
                o.OrderDate = dateTimePicker1.Text;
                o.TotalAmount = Convert.ToInt32(textBox4.Text);


                o.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orders o = new Orders();
            DataTable dt = o.Read();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Orders o = new Orders();
            DataTable dt = o.Delete();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders o = new Orders();
            DataTable dt = o.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
