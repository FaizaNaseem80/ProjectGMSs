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
    public partial class InventoryUpdate : Form
    {
        public InventoryUpdate()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-VKORAQ4\\MSSQLSERVERR;Initial Catalog=FMS;Integrated Security=True";
            Inventorys i = new Inventorys();
            int Proid = int.Parse(textBox1.Text);
            int ExQTY = int.Parse(textBox3.Text);
            int NewQTY = int.Parse(textBox4.Text);
            i.UpdateQuantity(connectionString, Proid, ExQTY, NewQTY);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventorys i = new Inventorys();
            DataTable dt = i.Read();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Inventory i=new Inventory();
            i.Show();
            this.Hide();
        }
    }
}
