using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trips.Visible = true;
           List<Trips> T = new List<Trips>();
           dataGridView1.Rows.Clear();
           if (Form0.loadData.Driver_Trips.ContainsKey(Form5.idD) == true)
           {
               T = Form0.loadData.Driver_Trips[Form5.idD];
               for (int i = 0; i < T.Count; i++)
               {
                   string Cname = "";
                   for (int j = 0; j < Form0.loadData.List_Client.Count; j++)
                   {

                       if (T[i].getid() == Form0.loadData.List_Client[j].get_id())
                       {
                           Cname = Form0.loadData.List_Client[j].get_name();
                           break;
                       }

                   }
                   dataGridView1.Rows.Add(Cname, T[i].getSource(), T[i].getDestination(), T[i].getPrice(),T[i].getDate());
               }
           }
           else
           {
               MessageBox.Show("You have made no trips");
           }
        }

        Stopwatch watch = new Stopwatch();
        Requests k;
        private void button1_Click(object sender, EventArgs e)
        {

            k = new Requests();
            watch.Start();
            string s="";
            for (int i =0 ; i< Form0.loadData.List_Driver.Count ; i++){

                if (Form0.loadData.List_Driver[i].getDriverId()==Form5.idD)
                {s=Form0.loadData.List_Driver[i].getStatus();}
            }
            if (s == "busy") { MessageBox.Show("You can't take requests now you are busy"); }
            else
            {
            if (Form0.loadData.requests.Count == 0)
            {
                MessageBox.Show("no pending request ");
            }
            else
            {
                k = Form0.loadData.requests.Dequeue();

                ride.Visible = true;
            }
            }

            //hna mfrod n cout 2l request
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form5 f52 = new Form5();
            this.Hide();
            f52.ShowDialog();
            this.Close();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            trips.Visible = false;

        }

     

        private void status_Click(object sender, EventArgs e)
        {
            stat.Visible = true;
            //hna da buttonn bta3 chang 2l status 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stat.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form0.loadData.List_Driver.Count; i++)
            {
                if (Form5.idD == Form0.loadData.List_Driver[i].getDriverId())
                {
                    string s = Form0.loadData.List_Driver[i].getStatus();
                    if (s == "available")
                    {
                        MessageBox.Show("Your Status is already available");
                    }
                    else
                    {
                        Form0.loadData.List_Driver[i].setStatus("available");
                        MessageBox.Show("Your Status has been changed ");
                    }
                    break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form0.loadData.List_Driver.Count; i++)
            {
                if (Form5.idD == Form0.loadData.List_Driver[i].getDriverId())
                {
                  string s=  Form0.loadData.List_Driver[i].getStatus();
                  if (s == "busy")
                  {
                      MessageBox.Show("Your Status is already busy");
                  }
                  else
                  {
                      Form0.loadData.List_Driver[i].setStatus("busy");
                      MessageBox.Show("Your Status has been changed ");
                  }
                  break;
                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e) //stop hena
        {
            ride.Visible = false;
            watch.Stop();
            var elapseMs = watch.ElapsedMilliseconds;
            long p = (elapseMs / 1000) * 5;
           if (Form2.isPromo == true)
            {
                p = p / 10;
            }
           if( p<0)
            p = 0;
            DateTime time = DateTime.Now;
            String formate = "d M yyyy";
            string s = time.ToString(formate);

            Trips td = new Trips(k.get_id(), k.get_pickup(), k.get_dropoff(), s, p);
            if (Form0.loadData.Driver_Trips.Keys.Contains(Form5.idD) == false)
            {
                Form0.loadData.Driver_Trips[Form5.idD] = new List<Trips>();

            }
            Form0.loadData.Driver_Trips[Form5.idD].Add(td);


            Trips tc = new Trips(Form5.idD, k.get_pickup(), k.get_dropoff(), s, p);
            if (Form0.loadData.client_Trips.Keys.Contains(k.get_id()) == false)
            {
                Form0.loadData.client_Trips[k.get_id()] = new List<Trips>();

            }

            Form0.loadData.client_Trips[k.get_id()].Add(tc);
        }
         
        private void ride_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
