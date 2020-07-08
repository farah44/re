using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
   

namespace WindowsFormsApplication1
{    
    
    public partial class Form1 : Form
    {  // OpenFileDialog openfile = new OpenFileDialog();   string line = "";
  
       
        
        public Form1()
        {
            InitializeComponent();
            
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "carhorn.wav";
            player.Play();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Close();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
