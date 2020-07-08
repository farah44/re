using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Trips
    {

        private string Source;
        private string Destination;
        private string date;

        private long Price;
        private int id;

        public Trips(int iddd, string source, string destination, string d, long price)
        {
            Source = source;
            Destination = destination;
            date = d;

            Price = price;
            id = iddd;
        }
        public string getSource()
        {
            return Source;
        }
        public string getDestination()
        {
            return Destination;
        }
        public string getDate()
        {
            return date;
        }
        public int getid()
        {
            return id;
        }

        public long getPrice()
        {
            return Price;
        }
        public void setSource(string s)
        {
            Source = s;
        }
        public void setDestination(string D)
        {
            Destination = D;
        }


    }
}
