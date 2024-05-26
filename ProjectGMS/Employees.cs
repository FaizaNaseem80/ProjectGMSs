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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

                //this.Hide();

            //// Instantiate Form2
            //Home l= new Home();

            //// Show Form2
            //l.ShowDialog();

            //// Close the application when Form2 is closed
            //Application.Exit();
            Employee e1 = new Employee();
            DataTable dt = e1.Read();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            try
            {
                e1.Empid = Convert.ToInt32(textBox1.Text);
                e1.Empname = textBox2.Text;
                e1.EmpType = comboBox1.Text;
               e1.Empcontact = Convert.ToInt32(textBox3.Text);
                e1.Empaddress = textBox4.Text;
                e1.EmpEmail = textBox5.Text;
                e1.EmpPassword = textBox6.Text;

                e1.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            DataTable dt = e1.Read();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
        Employee e1 = new Employee();
            DataTable dt = e1.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            try
            {
                e1.Empid = Convert.ToInt32(textBox1.Text);
                e1.Empname = textBox2.Text;
                e1.EmpType = comboBox1.Text;
                e1.Empcontact = Convert.ToInt32(textBox3.Text);
                e1.Empaddress = textBox4.Text;
                e1.EmpEmail = textBox5.Text;
                e1.EmpPassword = textBox6.Text;
                e1.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Employee e1 = new Employee();
            DataTable dt = e1.Delete();
            dataGridView1.DataSource = dt;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }
    }
}
