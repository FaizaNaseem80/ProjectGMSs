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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            //this.Hide();

            //// Instantiate Form2
            //Suppliers S2 = new Suppliers();

            //// Show Form2
            //S2.ShowDialog();

            // Close the application when Form2 is closed
            //Application.Exit();
            Stores S = new Stores();
            DataTable dt = S.Read();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stores S = new Stores();
            try
            {
                S.Sid = Convert.ToInt32(textBox1.Text);
                S.Sname = textBox2.Text;
                S.Slocation = textBox3.Text;
                S.Scontact = Convert.ToInt32(textBox4.Text);
                

                S.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stores S = new Stores();
            DataTable dt = S.Read();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
               Stores S = new Stores();
            DataTable dt = S.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Stores S = new Stores();
            try
            {
                S.Sid = Convert.ToInt32(textBox1.Text);
                S.Sname = textBox2.Text;
                S.Slocation = textBox3.Text;
                S.Scontact = Convert.ToInt32(textBox4.Text);
                S.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stores S = new Stores();
            DataTable dt = S.Delete();
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
