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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form5 f53 = new Form5();
            this.Hide();
            f53.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form0.loadData.Cars_Data.Count() == Form0.loadData.List_Driver.Count())
            {
                MessageBox.Show("No available drivers to assign car for ");
            }
            else
                newcar.Visible = true;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            newdriver.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reporttrips.Visible = true;
            dataGridView1.Rows.Clear();

            string cname = "";
            string dname = "";
            //string plateno,colorr,yearr,modell;
            for (int i = 0; i < Form0.loadData.List_Client.Count; i++)
            {
                if (Form0.loadData.client_Trips.ContainsKey(Form0.loadData.List_Client[i].get_id()) == true)
                {

                    cname = Form0.loadData.List_Client[i].get_name();
                    List<Trips> T = new List<Trips>();
                    T = Form0.loadData.client_Trips[Form0.loadData.List_Client[i].get_id()];

                    for (int j = 0; j < T.Count; j++)
                    {
                        for (int k = 0; k < Form0.loadData.List_Driver.Count; k++)
                        {
                            if (T[j].getid() == Form0.loadData.List_Driver[k].getDriverId())
                            {
                                dname = Form0.loadData.List_Driver[k].getDriverName();
                                break;
                            }
                        }
                        Cars carr = new Cars();

                        carr = Form0.loadData.Cars_Data[T[j].getid()];

                        dataGridView1.Rows.Add(cname, dname, T[j].getSource(), T[j].getDestination(), T[j].getPrice(),
                       T[j].getDate(), carr.getPlateNo(), carr.getModel(), carr.getColor(), carr.getYear());
                    }

                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string name, pass, status, salary;
            string id;
            name = NameD.Text;
            pass = PassD.Text;
            id = idd.Text;
            status = Status.Text;
            salary = Salary.Text;
            bool existid = false;
            bool existname = false;

            if (name.Length == 0 || pass.Length == 0 || id.Length == 0 || status.Length == 0 || salary.Length == 0)
            {
                MessageBox.Show("Please complete the new driver information");
            }
            if (int.Parse(salary) < 0)
            {
                MessageBox.Show("salary can't be in negative ");
                Salary.Clear();
            }
            else
            {
                for (int i = 0; i < Form0.loadData.List_Driver.Count(); i++)
                {
                    if (Form0.loadData.List_Driver[i].getDriverId() == int.Parse(id))
                    {
                        existid = true;
                    }

                    if (name == Form0.loadData.List_Driver[i].getDriverName())
                    {
                        existname = true;
                    }
                }
                if (existid == true || existname == true)
                {
                    MessageBox.Show("Driver id or name  already exists");
                    NameD.Clear();
                    
                    idd.Clear();
                    
                }
                else
                {
                    Driver d1 = new Driver(name, pass, int.Parse(id), int.Parse(salary), status);
                    Form0.loadData.List_Driver.Add(d1);
                    newcar.Visible = false;
                    newdriver.Visible = false;
                    reporttrips.Visible = false;

                }
            }
        }

        private void idd_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            newdriver.Visible = false;
            newcar.Visible = false;
            reporttrips.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            newcar.Visible = false;
        }

        private void newdriver_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            newcar.Visible = false;
            newdriver.Visible = false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            newcar.Visible = false;
            newdriver.Visible = false;
            reporttrips.Visible = false;
            string Model, colour, Year, plate, id;
            plate = plateno.Text;
            colour = color.Text;
            Year = year.Text;
            Model = model.Text;
            id = iddd.Text;
            if (plate.Length == 0 || colour.Length == 0 || Year.Length == 0 || Model.Length == 0)
            {
                MessageBox.Show("Please complete the new Car information");
            }
            if (Form0.loadData.Cars_Data.ContainsKey(int.Parse(id)) == true)
            {
                MessageBox.Show("Driver id has a car already");
                plateno.Clear();
                color.Clear();
                year.Clear();
                model.Clear();
                iddd.Clear();
            }
            else
            {
                Cars c1 = new Cars(plate, colour, int.Parse(Year), Model);
                Form0.loadData.Cars_Data.Add(int.Parse(id), c1);
                plateno.Clear();
                color.Clear();
                year.Clear();
                model.Clear();
                iddd.Clear();
            }
           

        }

        private void iddd_TextChanged(object sender, EventArgs e)
        {

        }

        private void reporttrips_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //fel button el ye add feh promo
        //add fel list bt3t el inserting
    }
}

