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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
          
        }


        private void Register_Click(object sender, EventArgs e)
        {
            string username, pass;
            username = RUN.Text;
            pass = RP.Text;
            bool name = false;
            int Last_Id =0;
            if (Form0.loadData.List_Client.Count()>0)
                Last_Id = Form0.loadData.List_Client[Form0.loadData.List_Client.Count() - 1].get_id();

            if (username.Length == 0 || pass.Length == 0)
            {
                MessageBox.Show(" You must check your registeration ");
            }

            else
            {
                username = username.Trim();
                
                for (int i = 0; i < Form0.loadData.List_Client.Count; i++)
                {
                    if (username == Form0.loadData.List_Client[i].get_name())
                    {
                        name = true;
                        break;
                    }
                }
                    if (name == true)
                    {
                        MessageBox.Show("name already exists");
                        RUN.Clear();
                    }
                    else
                    {

                        

                        Last_Id++;
                        Client newClient = new Client(Last_Id, username, pass);

                        Form0.loadData.List_Client.Add(newClient);

                        MessageBox.Show(" Register completed ");
                    }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form5 f52 = new Form5();
            this.Hide();
            f52.ShowDialog();
            this.Close();
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                RP.PasswordChar = default(char);
            }
            else
            {
                RP.PasswordChar = '*';
            }
        }
    }
}
