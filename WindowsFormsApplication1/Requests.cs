using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Requests
    {
        public string pickup;
        public string dropoff;
        public int id;

        public Requests(int idd, string drop, string pick)
        {
            pickup = pick;
            dropoff = drop;
            id = idd;

        }
        public Requests()
        {
            pickup = "";
            dropoff ="";
            id=0;

        }
        public string get_pickup()
        {
            return pickup;
        }
        public string get_dropoff()
        {
            return dropoff;
        }
        public int get_id()
        {
            return id;
        }
        public void setpickup(string pick)
        {
            pickup = pick;
        }
        public void setdropff(string drop)
        {
            dropoff = drop;
        }
        public void setid(int  idd)
        {
            id  = idd;
        }

    }
}
