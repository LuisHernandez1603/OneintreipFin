using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneintreipFin
{
    public partial class Form1 : Form
    {
        int tiempo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                timer.Interval = 50;
                timer.Start();



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo < 4000)
            {
                tiempo += 40;
                progressBar1.Value += 1;
            }
            else
            {
                this.Close();
                timer.Stop();
            }


        }
    }
}
