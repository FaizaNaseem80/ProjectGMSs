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
    public partial class Salarys : Form
    {
        public Salarys()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salary S = new Salary();
            try
            {
                S.Empid = Convert.ToInt32(textBox1.Text);
                S.Allowance = Convert.ToInt32(textBox2.Text);
                S.Deductions = Convert.ToInt32(textBox3.Text);
                S.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salarys_Load(object sender, EventArgs e)
        {
            Salary S= new Salary();
            DataTable dt = S.Read();
            dataGridView1.DataSource = dt;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salary S = new Salary();
            try
            {
                S.Empid = Convert.ToInt32(textBox1.Text);
                S.Allowance = Convert.ToInt32(textBox2.Text);
                S.Deductions = Convert.ToInt32(textBox3.Text);
                S.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Salary S = new Salary();
            DataTable dt = S.Delete();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salary S = new Salary();
            DataTable dt = S.Read();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Salary S = new Salary();
            DataTable dt = S.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentCell.Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            DataTable dt = e1.Read();
            dataGridView2.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
