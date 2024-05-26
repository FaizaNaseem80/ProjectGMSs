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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

     

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void employeesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void suppliersInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers s1 = new Suppliers();
            s1.Show();
            this.Hide();

        }

        private void expensesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Expenses e2 = new Expenses();
            e2.Show();

        }

        private void storeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store s2 = new Store();
            s2.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees e1 = new Employees();
            e1.Show();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees e1 = new Employees();
            e1.Show();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void maintainanceWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
            

        private void Home_Load(object sender, EventArgs e)
        {

        }

        

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Login_Form l = new Login_Form();
            l.Show();
            this.Hide();
        }

        private void cashierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            l.Show();
            this.Hide();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            l.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paymentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment P = new Payment();
            P.Show();
            this.Hide();
        }

        private void salaryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salarys s= new Salarys();
            s.Show();
            this.Hide();
        }

        private void productInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products P= new Products();
            P.Show();
            this.Hide();
        }

        private void categoryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Categorys C = new Categorys();
            C.Show();
            this.Hide();
        }

        private void promotionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promotions P = new Promotions();
            P.Show();
            this.Hide();
        }

        private void loginAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login_Form f = new Login_Form();
            f.Show();
            this.Hide();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transactionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            t.Show();
            this.Hide();
        }

        private void orderInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
            this.Hide();

        }

        private void transactionDetailInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionDetails t = new TransactionDetails();
            t.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.Show();
            this.Hide();
        }

        private void productimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProImage p = new ProImage();
            p.Show();
            this.Hide();
        }
    }
    }

