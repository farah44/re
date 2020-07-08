using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{

    public class Load
    {
        public List<Driver> List_Driver ;
        public List<Client> List_Client ;
        public List<Admin> list_admin ;
        public List<string> promoCodes;
        
        public Queue<Requests> requests ;
        public Dictionary<int, Cars> Cars_Data ;

        public Dictionary<int, List<Trips>> client_Trips ;
        public Dictionary<int, List<Trips>> Driver_Trips;
        public Load()
        {
            List_Driver = new List<Driver>();
            List_Client = new List<Client>();
            list_admin = new List<Admin>();
            promoCodes = new List<String>();
            
            requests = new Queue<Requests>();
            Cars_Data = new Dictionary<int, Cars>();

            client_Trips = new Dictionary<int, List<Trips>>();
            Driver_Trips = new Dictionary<int, List<Trips>>();

        }
        public void rewrite_cars()
        {
            StreamWriter sw = new StreamWriter("car.txt", false, Encoding.ASCII);
            string line = "";
            for (int x = 0; x < List_Driver.Count(); x++)
            {

                if (Cars_Data.ContainsKey(List_Driver[x].getDriverId()) == true)
                {
                    line += List_Driver[x].getDriverId();
                    line += " ";
                    Cars c = Cars_Data[List_Driver[x].getDriverId()];
                    line += c.getModel();
                    line += " ";
                    line += c.getColor();
                    line += " ";
                    line += c.getYear();
                    line += " ";
                    line += c.getPlateNo();
                    sw.WriteLine(line);
                    line = "";
                }
            }
            //close the file
            sw.Close();
        }
        public void rewrite_Driver()
        {
            StreamWriter sw = new StreamWriter("driver.txt", false, Encoding.ASCII);
            string line = "";

            for (int x = 0; x < List_Driver.Count(); x++)
            {
                line += List_Driver[x].getDriverId();
                line += " ";
                line += List_Driver[x].getDriverName();
                line += " ";
                line += List_Driver[x].getPass();
                line += " ";
                line += List_Driver[x].getSalary();
                line += " ";
                line += List_Driver[x].getStatus();
                sw.WriteLine(line);
                line = "";
            }

            //close the file
            sw.Close();
        }
        public void rewrite_Client()
        {
            StreamWriter sw = new StreamWriter("client.txt", false, Encoding.ASCII);
            string line = "";

            for (int x = 0; x < List_Client.Count(); x++)
            {
                line += List_Client[x].get_id();
                line += " ";
                line += List_Client[x].get_name();
                line += " ";
                line += List_Client[x].get_passward();

                sw.WriteLine(line);
                line = "";
            }

            //close the file
            sw.Close();
        }
        public void rewrite_TripsDrivers()
        {
            StreamWriter sw = new StreamWriter("driver trips.txt", false, Encoding.ASCII);
           string line = "";
            for (int i = 0; i < List_Driver.Count; i++)
            {
                if (Driver_Trips.ContainsKey(List_Driver[i].getDriverId()) == true)
                {
                    
                    List<Trips>t=new List<Trips>();
                    t = Driver_Trips[List_Driver[i].getDriverId()];
                    for (int j =0 ; j < t.Count ; j++)
                    {
                        line += List_Driver[i].getDriverId();
                        line += " ";
                        line +=t[j].getid();
                        line += " ";
                        line +=t[j].getSource();
                        line += " ";
                        line +=t[j].getDestination();
                        line += " ";
                        line +=t[j].getDate();
                         line += " ";
                         line +=t[j].getPrice();
                         sw.WriteLine(line);
                       line = "";
                          }
                }
            }
        
               sw.Close();
        }
        public void rewrite_TripsClient()
        {
            StreamWriter sw = new StreamWriter("client trips.txt", false, Encoding.ASCII);
            string line = "";
            for (int i = 0; i < List_Client.Count; i++)
            {
                if (client_Trips.ContainsKey(List_Client[i].get_id()) == true)
                {
                   
                    List<Trips>t=new List<Trips>();
                    t=client_Trips[List_Client[i].get_id()];
                    for (int j =0 ; j < t.Count ; j++)
                    {
                        line += List_Client[i].get_id();
                        line += " ";
                        line +=t[j].getid();
                        line += " ";
                        line +=t[j].getSource();
                        line += " ";
                        line +=t[j].getDestination();
                        line += " ";
                        line +=t[j].getPrice();
                        line += " ";
                        line +=t[j].getDate();
                         sw.WriteLine(line);
                       line = "";
                          }
                }
            }
        
               sw.Close();
        }
        

           
         public void promos()
        {
            try
            {
                using (StreamReader sr = new StreamReader("promocodes.txt"))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        promoCodes.Add(line);
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("The file of promo can not be opened");
            }
        }

        public void loadtripsDrivers()
        {
            try
            {
                using (StreamReader sr = new StreamReader("driver trips.txt"))
                {

                    string line;
                    string source, destination;
                    while ((line = sr.ReadLine()) != null)
                    {

                        int DriverId = int.Parse(line.Split(' ')[0]);
                        int ClientId = int.Parse(line.Split(' ')[1]);
                        source = line.Split(' ')[2];
                        destination = line.Split(' ')[3];
                        string date = line.Split(' ')[4] + " " + line.Split(' ')[5] + " " + line.Split(' ')[6];
                        int price = int.Parse(line.Split(' ')[7]);
                        Trips currenttrip = new Trips(ClientId, source, destination, date, price);
                        if (Driver_Trips.Keys.Contains(DriverId) == false)
                        {
                            Driver_Trips[DriverId] = new List<Trips>();

                        }
                        Driver_Trips[DriverId].Add(currenttrip);
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("The file of trips driver can not be opened");
            }
        }
        public void loadtripsClient()
        {
            try
            {
                using (StreamReader sr = new StreamReader("client trips.txt"))
                {

                    string line;
                    string source, destination;
                    while ((line = sr.ReadLine()) != null)
                    {

                        int ClientId = int.Parse(line.Split(' ')[0]);
                        int DriverId = int.Parse(line.Split(' ')[1]);
                        source = line.Split(' ')[2];
                        destination = line.Split(' ')[3];
                        int price = int.Parse(line.Split(' ')[4]);
                        string date = line.Split(' ')[5] + " " + line.Split(' ')[6] + " " + line.Split(' ')[7];
                        Trips currenttrip = new Trips(DriverId, source, destination, date, price);
                        if (client_Trips.Keys.Contains(ClientId) == false)
                        {
                            client_Trips[ClientId] = new List<Trips>();

                        }
                        client_Trips[ClientId].Add(currenttrip);
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("The file of client trips can not be opened");
            }
        }
         public void loadRequest()
        {
            try
            {
                using (StreamReader sr = new StreamReader("request.txt"))
                {

                    string line;
                    string id,nam, pass;
                    while ((line = sr.ReadLine()) != null)
                    {
                        id=line.Split(' ')[0];
                        nam = line.Split(' ')[1];
                        pass = line.Split(' ')[2];
                        Requests r = new Requests(int.Parse(id),nam, pass);
                        requests.Enqueue(r);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file of request can not be opened");
            }
        }
         public void rewriteRequest()
         {
             StreamWriter sw = new StreamWriter("request.txt", false, Encoding.ASCII);

             string line = "";

             for (int i = 0; i < requests.Count; i++)
             {
                 Requests r = new Requests();
                 r = requests.Dequeue();
                 line += r.get_id();
                 line += " ";
                 line += r.get_pickup();
                 line += " ";
                 line += r.get_dropoff();
                 sw.WriteLine(line);
                 line = "";

             }
            sw.Close();
         }
                

        public void loadadmin()
        {
            try
            {
                using (StreamReader sr = new StreamReader("admin.txt"))
                {

                    string line;
                    string nam, pass;
                    while ((line = sr.ReadLine()) != null)
                    {

                        nam = line.Split(' ')[0];
                        pass = line.Split(' ')[1];
                        Admin currentadmin = new Admin(nam, pass);
                        list_admin.Add(currentadmin);

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("The file of admins can not be opened");
            }
        }
        public void loadcar()
        {
            try
            {
                using (StreamReader sr = new StreamReader("car.txt"))
                {

                    string line;
                    string plateNo, color, model;
                    while ((line = sr.ReadLine()) != null)
                    {

                        int id = int.Parse(line.Split(' ')[0]);
                        model = line.Split(' ')[1];
                        plateNo = line.Split(' ')[2];
                        int year = int.Parse(line.Split(' ')[3]);
                        color = line.Split(' ')[4];
                        Cars currentcar = new Cars(plateNo, color, year, model);
                        Cars_Data.Add(id, currentcar);

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("The file of cars can not be opened");
            }

        }
        public void loadClient()
        {
            try
            {
                using (StreamReader sr = new StreamReader("client.txt"))
                {

                    string line;
                    string name, pass;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int id = int.Parse(line.Split(' ')[0]);
                        name = line.Split(' ')[1];
                        pass = line.Split(' ')[2];
                        Client currentclient = new Client(id, name, pass);
                        List_Client.Add(currentclient);

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("The file of clients can not be opened");
            }
        }
        public void loadDriver()
        {
            try
            {
                using (StreamReader sr = new StreamReader("driver.txt"))
                {

                    string line;
                    string name, pass, status;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int id = int.Parse(line.Split(' ')[0]);
                        name = line.Split(' ')[1];
                        pass = line.Split(' ')[2];
                        int salary = int.Parse(line.Split(' ')[3]);
                        status = line.Split(' ')[4];
                        Driver currentdriver = new Driver(name, pass, id, salary, status);
                        List_Driver.Add(currentdriver);
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("The file of driver can not be opened");
            }
        }




    }
}

