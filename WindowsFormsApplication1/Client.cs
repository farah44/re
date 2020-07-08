using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class Client
    {
        private int Client_id;
        private string Client_name;
        private string Client_password;


  

        public Client(int id, string name, string password)
        {

            Client_id = id;
            Client_name = name;
            Client_password = password;

        }
        public int get_id()
        {
            return Client_id;
        }

        public string get_name()
        {
            return Client_name;
        }
        public string get_passward()
        {
            return Client_password;
        }
    }
}
