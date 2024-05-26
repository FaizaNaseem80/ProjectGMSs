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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

            this.Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            DataTable dt2 = c.Read();
            dataGridView5.DataSource = dt2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Supplier S = new Supplier();
            DataTable dt = S.Read();
            dataGridView5.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stores S1 = new Stores();
            DataTable dt1 = S1.Read();
            dataGridView5.DataSource = dt1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Expense E = new Expense();
            DataTable dt3 = E.Read();
            dataGridView5.DataSource = dt3;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Employee e1 = new Employee();
            DataTable dt4 = e1.Read();
            dataGridView5.DataSource = dt4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Employees e1=new Employees();
            e1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Payments P = new Payments();
            DataTable dt4 = P.Read();
            dataGridView5.DataSource = dt4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Salary S=new Salary();
            DataTable dt4 = S.Read();
            dataGridView5.DataSource = dt4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            DataTable dt4 = P.Read();
            dataGridView5.DataSource = dt4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Category C=new Category();
            DataTable dt4 = C.Read();
            dataGridView5.DataSource = dt4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Promotion P = new Promotion();
            DataTable dt4 = P.Read();
            dataGridView5.DataSource = dt4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Transaction t=new Transaction();
            DataTable dt4 = t.Read();
            dataGridView5.DataSource = dt4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Orders o = new Orders();
            DataTable dt4 = o.Read();
            dataGridView5.DataSource = dt4;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TransactionDetail t = new TransactionDetail();
            DataTable dt4 = t.Read();
            dataGridView5.DataSource = dt4;
        }
    }
}
