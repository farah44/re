using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApplication1
{
   public class Driver
    {
        private int Driver_ID;
        private string Name;
        private string Pass;
        private int Salary;
        private string Status;
      


        public Driver(string name, string pass, int id, int salary, string status)
        {
            Driver_ID = id;
            Name = name;
            Pass = pass;
            Salary = salary;
            Status = status;
        }
        public int getDriverId()
        {
            return Driver_ID;
        }
        public string getDriverName()
        {
            return Name;
        }
        public string getPass()
        {
            return Pass;
        }
      
        public string getStatus()
        {

            return Status;
        }
        public int getSalary()
        {
            return Salary;
        }
        public void setStatus(string status)
        {
            Status = status;
        }

    }
}
