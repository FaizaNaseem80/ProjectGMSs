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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView3.CurrentCell.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction t=new Transaction();
            try
            {
                t.Transid = Convert.ToInt32(textBox1.Text);
                t.Empid = Convert.ToInt32(textBox2.Text);
                t.Payid = Convert.ToInt32(textBox3.Text);
                t.TransDate = dateTimePicker1.Text;

                t.Create();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            DataTable dt = t.Read();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            DataTable dt =t.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            DataTable dt = t.Delete();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            try
            {
                t.Transid = Convert.ToInt32(textBox1.Text);
                t.Empid = Convert.ToInt32(textBox2.Text);
                t.Payid = Convert.ToInt32(textBox3.Text);
                t.TransDate = dateTimePicker1.Text;

                t.Update();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Payments P = new Payments();
            DataTable dt = P.Read();
            dataGridView2.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            DataTable dt = e1.Read();
            dataGridView3.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentCell.Value.ToString();
        }
    }
    }
