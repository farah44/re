using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Admin
    {    private string name;
        private string passward;
       
        public Admin(string nam, string pass)
        {
            name = nam;
            passward = pass;
        }
        public string get_name()
        {
            return name;
        }
        public string get_passward()
        {
            return passward;
        }

    }
}
