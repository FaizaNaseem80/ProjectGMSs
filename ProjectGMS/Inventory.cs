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
    public partial class Inventory : Form
    {

        public int Proid { get; internal set; }

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Inventorys i = new Inventorys();
            DataTable dt = i.Read();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventorys i = new Inventorys();

            try
            {

                i.Proid = Convert.ToInt32(textBox1.Text);
                i.Supid = Convert.ToInt32(textBox2.Text);
                i.ExQTY = Convert.ToInt32(textBox3.Text);
                i.NewQTY = Convert.ToInt32(textBox4.Text);
                i.ReorderLevel = Convert.ToInt32(textBox5.Text);
                i.BatchId = Convert.ToInt32(textBox6.Text);
          
                i.CateId = Convert.ToInt32(textBox8.Text);
             


                i.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventorys i = new Inventorys();

            try
            {
                i.Proid = Convert.ToInt32(textBox1.Text);
                i.Supid = Convert.ToInt32(textBox2.Text);
                i.ExQTY = Convert.ToInt32(textBox3.Text);
                i.NewQTY = Convert.ToInt32(textBox4.Text);
                i.ReorderLevel = Convert.ToInt32(textBox5.Text);
                i.BatchId = Convert.ToInt32(textBox6.Text);
              
                i.CateId = Convert.ToInt32(textBox8.Text);
                i.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventorys i = new Inventorys();
            DataTable dt = i.Read();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inventorys i = new Inventorys();
            DataTable dt = i.Read(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inventorys i = new Inventorys();
            DataTable dt = i.Delete();
            dataGridView1.DataSource = dt;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                textBox1.Text = dataGridView1.CurrentCell.Value.ToString();
                textBox2.Text = dataGridView1.CurrentCell.Value.ToString();
            }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            InventoryUpdate i = new InventoryUpdate();
            i.Show();
            this.Hide();
           
        }
    }
    }