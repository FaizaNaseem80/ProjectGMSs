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
    public partial class TransactionDetails : Form
    {
        public TransactionDetails()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transaction T=new Transaction();
            DataTable dt = T.Read();
            dataGridView2.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Product P=new Product();
            DataTable dt = P.Read();
            dataGridView3.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionDetail td=new TransactionDetail();

            try
            {

                td.Detailid= Convert.ToInt32(textBox1.Text);
                td.Transid = Convert.ToInt32(textBox2.Text);
                td.Proid= Convert.ToInt32(textBox3.Text);
                td.TQTY = Convert.ToInt32(textBox4.Text);
                td.TPrice= Convert.ToInt32(textBox5.Text);

                td.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransactionDetail td=new TransactionDetail();
            DataTable dt = td.Read();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransactionDetail td = new TransactionDetail();
            DataTable dt = td.Delete();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransactionDetail td = new TransactionDetail();

            try
            {

                td.Detailid = Convert.ToInt32(textBox1.Text);
                td.Transid = Convert.ToInt32(textBox2.Text);
                td.Proid = Convert.ToInt32(textBox3.Text);
                td.TQTY = Convert.ToInt32(textBox4.Text);
                td.TPrice = Convert.ToInt32(textBox5.Text);

                td.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TransactionDetail td = new TransactionDetail();
            DataTable dt = td.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentCell.Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView3.CurrentCell.Value.ToString();
        }
    }
    }
