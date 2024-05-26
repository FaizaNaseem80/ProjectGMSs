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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {

            //this.Hide();

            //// Instantiate Form2
            //Expenses E3 = new Expenses();

            //// Show Form2
            //E3.ShowDialog();

            //// Close the application when Form2 is closed
            //Application.Exit();
            Supplier S = new Supplier();
            DataTable dt = S.Read();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier S= new Supplier();
            try
            {
                S.Supid = Convert.ToInt32(textBox1.Text);
                S.Supname = textBox2.Text;
                S.Supcontact = Convert.ToInt32(textBox3.Text);
                S.Supaddress = textBox4.Text;

                S.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier S = new Supplier();
            DataTable dt = S.Read();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Supplier S = new Supplier();
            try
            {

                S.Supid = Convert.ToInt32(textBox1.Text);
                S.Supname = textBox2.Text;
                S.Supcontact = Convert.ToInt32(textBox3.Text);
                S.Supaddress = textBox4.Text;
                S.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Supplier S = new Supplier();
            DataTable dt = S.Delete();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Supplier S = new Supplier();
            DataTable dt = S.Read();
            dataGridView1.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }
    }
}
