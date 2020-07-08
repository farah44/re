using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form0());
            Form0.loadData.rewrite_cars();
            Form0.loadData.rewrite_Client();
            Form0.loadData.rewrite_Driver();
            Form0.loadData.rewrite_TripsClient();
            Form0.loadData.rewrite_TripsDrivers();
            Form0.loadData.rewriteRequest();
           
        }
    }
}
