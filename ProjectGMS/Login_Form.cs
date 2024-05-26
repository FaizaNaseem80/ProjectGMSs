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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           User_Authentication a = new User_Authentication();
            DataTable dt = a.Login(textBox1.Text, textBox2.Text, comboBox1.Text);
            if (dt.Rows.Count > 0)
            {
                if (comboBox1.Text == "Worker")
                {
                    MessageBox.Show("Successfully Login As Worker");
                  Worker w=new Worker();
                    w.Show();
                    this.Hide();
                }
                else if (comboBox1.Text == "Admin")
                {
                    MessageBox.Show("Successfully Login As Admin");
                    Admin A=new Admin();
                    A.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Successfully Login As Cashier");
                    Cashier c=new Cashier();
                    c.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
