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
    public partial class Categorys : Form
    {
        public Categorys()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category C=new Category();
            try
            {
                C.CateId = Convert.ToInt32(textBox1.Text);
                C.CateName = textBox2.Text;
                C.CateDes = (textBox3.Text);
              
                C.Create();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category C = new Category();
            try
            {
                C.CateId = Convert.ToInt32(textBox1.Text);
                C.CateName = textBox2.Text;
                C.CateDes = (textBox3.Text);

                C.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category C = new Category();
            DataTable dt = C.Read();
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Category C = new Category();
            DataTable dt = C.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Category C = new Category();
            DataTable dt = C.Delete();
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
