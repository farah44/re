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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
     
        private void button3_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            hist.Visible = true;
            dataGridView1.Rows.Clear();
           
            List<Trips> T = new List<Trips>();
            if (Form0.loadData.client_Trips.ContainsKey(Form5.idC) == true)
            {
                T = Form0.loadData.client_Trips[Form5.idC];
                for (int i = 0; i < T.Count; i++)
                {
                    string Dname = "";
                    for (int j = 0; j < Form0.loadData.List_Driver.Count; j++)
                    {

                        if (T[i].getid() == Form0.loadData.List_Driver[j].getDriverId())
                        {
                            Dname = Form0.loadData.List_Driver[j].getDriverName();
                            break;
                        }
                    }
                        Cars carr = new Cars();

                        carr = Form0.loadData.Cars_Data[T[i].getid()];

                   
                    dataGridView1.Rows.Add(Dname, T[i].getSource(), T[i].getDestination(),
                        T[i].getPrice(), T[i].getDate(), carr.getPlateNo(), carr.getModel(), carr.getColor(), carr.getYear());
                }
                

            }
            else
            {
                
                MessageBox.Show("You have made no rides till now");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Form5 f51 = new Form5();
            this.Hide();
            f51.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hist.Visible = false;

        }
       

        private void Reseve_Click(object sender, EventArgs e)
        {
            reserve.Visible = true;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            reserve.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string loc=location.Text;
            string des = destination.Text;

           string promo = textBox1.Text;
           if (promo.Length > 0)
           {
               isPromo = PROMO(promo);
               if (isPromo == false)
               {
                   MessageBox.Show("wrong promocode");
                   textBox1.Clear();
               }
           }

            if (loc.Length == 0 || des.Length == 0)
            {
                MessageBox.Show("please complete the data");
            }
            else if (loc == des)
            {
                MessageBox.Show("Can't accept your request information not valied please try agin ");
                location.Clear();
                destination.Clear();
            }
            else
            {
                int idc = Form5.idC;
                Requests R = new Requests(idc,loc,des);
                Form0.loadData.requests.Enqueue(R);
                MessageBox.Show("Request sent");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
           
        }

        private void location_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static bool isPromo = false;
        private void reserve_Paint(object sender, PaintEventArgs e)
        {

        }
        public string promo;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public bool PROMO(string p)
        {
            for (int i = 0; i < Form0.loadData.promoCodes.Count; i++)
            {
                if (p == Form0.loadData.promoCodes[i])
                    return true;

            }
            return false;
        }
    }
}
