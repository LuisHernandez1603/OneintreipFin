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
    public partial class DestinosTrip : Form
    {
        public DestinosTrip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                this.Hide();
            Horariostripcs horariostripcs = new Horariostripcs();
            horariostripcs.Show();
            this.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inciodesesion inciodesesion = new Inciodesesion();
            inciodesesion.Show();  
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
            this.Close();
        }
    }
}
