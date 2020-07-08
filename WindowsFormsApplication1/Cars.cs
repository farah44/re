using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class Cars
    {
        private string PlateNo;
        private string Color;
        private int Year;
        private string Model;

        public Cars()
        {
            PlateNo = "";
            Color = "";
            Year = 0;
            Model = "";
        }
        public Cars(string plateNo, string color, int year, string model)
        {
            PlateNo = plateNo;
            Color = color;
            Year = year;
            Model = model;

        }
       
        public string getPlateNo()
        {
            return PlateNo;
        }
        public string getColor()
        {
            return Color;
        }
        public string getModel()
        {
            return Model;
        }
        public int getYear()
        {
            return Year;
        }
    }
}
