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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Hide();

            //// Instantiate Form2
            //Employees E2 = new Employees();

            //// Show Form2
            //E2.ShowDialog();

            //// Close the application when Form2 is closed
            //Application.Exit();
            Customer c = new Customer();
            DataTable dt = c.Read();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            try
            {
                c.Cusid = Convert.ToInt32(textBox1.Text);
                c.Cusname = textBox2.Text;
                c.Cuscontact = Convert.ToInt32(textBox3.Text);
                c.Cusaddress = textBox4.Text;

                c.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            DataTable dt = c.Read();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            try
            {

                c.Cusid = Convert.ToInt32(textBox1.Text);
                c.Cusname = textBox2.Text;
                c.Cuscontact = Convert.ToInt32(textBox3.Text);
                c.Cusaddress = textBox4.Text;
                c.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            DataTable dt = c.Delete();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            DataTable dt = c.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
