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
    public partial class Promotions : Form
    {
        public Promotions()
        {
            InitializeComponent();
        }

        private void Promotions_Load(object sender, EventArgs e)
        {
            Promotion p1 = new Promotion();
            DataTable dt = p1.Read();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Promotion p1 = new Promotion();

            try
            {
            
            p1.Proid= Convert.ToInt32(textBox5.Text);
            p1.PrId = Convert.ToInt32(textBox1.Text);
            p1.Prdiscount = Convert.ToInt32(textBox2.Text);
                p1.PrSdate =dateTimePicker1.Text;
            p1.PrEdate = dateTimePicker2.Text;

                p1.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Promotion p1 = new Promotion();
            try
            {
                
                p1.Proid = Convert.ToInt32(textBox5.Text);
                p1.PrId = Convert.ToInt32(textBox1.Text);
                p1.Prdiscount = Convert.ToInt32(textBox2.Text);
                p1.PrSdate = dateTimePicker1.Text;
                p1.PrEdate = dateTimePicker2.Text;

                p1.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Promotion p1 = new Promotion();
            DataTable dt = p1.Read();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Promotion p1 = new Promotion();
            DataTable dt = p1.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Promotion p1 = new Promotion();
            DataTable dt = p1.Delete();
            dataGridView1.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           ///* textBox5.Text = dataGridView2.CurrentCell.Value.ToString*/();
        }
    }
    }
