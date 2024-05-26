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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {

            //this.Hide();

            //// Instantiate Form2
            //Store S2 = new Store();

            //// Show Form2
            //S2.ShowDialog();

            //// Close the application when Form2 is closed
            ////Application.Exit();
            Expense E = new Expense();
            DataTable dt = E.Read();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Expense E = new Expense();
            try
            {
                E.Exid = Convert.ToInt32(textBox1.Text);
                E.Exdes= textBox2.Text;
                E.Examount= Convert.ToInt32(textBox3.Text);
                E.Exdate = dateTimePicker1.Text; 

                E.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expense E = new Expense();
            DataTable dt = E.Read();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Expense E = new Expense();
            try
            {
                E.Exid = Convert.ToInt32(textBox1.Text);
                E.Exdes = textBox2.Text;
                E.Examount = Convert.ToInt32(textBox3.Text);
                E.Exdate = dateTimePicker1.Text;

                E.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Expense E = new Expense();
            DataTable dt = E.Delete();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Expense E = new Expense();
            DataTable dt = E.Read(Convert.ToInt32(textBox1.Text));
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
