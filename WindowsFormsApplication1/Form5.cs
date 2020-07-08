using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       
        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Form1 f11 = new Form1();
            this.Hide();
            f11.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form1 f11 = new Form1();
            this.Hide();
            f11.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Driver.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin.Visible = true;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
            Form1 f12 = new Form1();
            this.Hide();
            f12.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Form1 f13 = new Form1();
            this.Hide();
            f13.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Form1 f14 = new Form1();
            this.Hide();
            f14.ShowDialog();
            this.Close();
        }

      

        private void button6_Click(object sender, EventArgs e)
            
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            
            string username, password;
            username = SAU.Text;
            password = SAP.Text;
            username.Trim();
            password.Trim();

            if (checkerA(username, password) == false)
            {
                MessageBox.Show("Wrong Username Or Password");
                SAU.Clear();
                SAP.Clear();
            }
            else
            {
                Form6 f6 = new Form6();
                this.Hide();
                f6.ShowDialog();
                this.Close();
                
            }
          
        }
        public static int idC;
        private void button6_Click_1(object sender, EventArgs e)

        {

           
            string user, pass;
            user = SCU.Text;
            pass = SCP.Text;
            user.Trim();
            pass.Trim();
            idC = checkerC(user, pass);
            if (idC == -1)
            {
                MessageBox.Show("Wrong Username Or Password");
                SCU.Clear();
                SCP.Clear();
            }
            else
                
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Close();
                
            }
        }
        public int checkerC(string un, string pd)
        {


            for (int i = 0; i < Form0.loadData.List_Client.Count(); i++)
            {
                if (un == Form0.loadData.List_Client[i].get_name() && pd == Form0.loadData.List_Client[i].get_passward())
                {
                    return Form0.loadData.List_Client[i].get_id();
                }
            }
            return -1;

        }
        public static int idD;
        private void button10_Click_2(object sender, EventArgs e)
        {
            
            string username, password;
            username = SDU.Text;
            password = SDP.Text;
            username = username.Trim();
            password = password.Trim();
            idD = checkerD(username, password);
            if (idD == -1)
            {
                MessageBox.Show("Wrong Username Or Password");
                SDU.Clear();
                SDP.Clear();
            }
            else
            {
              Form3 f3 = new Form3();
              this.Hide();
              f3.ShowDialog();
              this.Close();
               
               
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }
        public int checkerD (string un, string pd)
        {
             
             
            for (int i = 0; i < Form0.loadData.List_Driver.Count(); i++)
            {
                if (un == Form0.loadData.List_Driver[i].getDriverName() && pd == Form0.loadData.List_Driver[i].getPass())
               {
                   return Form0.loadData.List_Driver[i].getDriverId();
               }
            }
            return -1;
          
        }
           

        public bool checkerA(string une,string pass)
        {


            for (int i = 0; i < Form0.loadData.list_admin.Count(); i++)
            {
                if (une == Form0.loadData.list_admin[i].get_name() && pass == Form0.loadData.list_admin[i].get_passward())
                {
                    return true;
                }
            }
            return false;
        }

        private void SAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SDP.PasswordChar = default(char);
            }
            else
            {
                SDP.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SCP.PasswordChar = default(char);
            }
            else
            {
                SCP.PasswordChar = '*';
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SAP.PasswordChar = default(char);
            }
            else
            {
                SAP.PasswordChar = '*';
            }
        }

        private void Driver_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
