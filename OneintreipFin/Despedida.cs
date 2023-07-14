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
    public partial class Despedida : Form
    {
        public Despedida()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DestinosTrip destinosTripForm
                  = new DestinosTrip();
            destinosTripForm.Show();
            this.Close();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProfile usuario = new MyProfile();
            usuario.Show(); 
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda ayuda = new Ayuda();
            ayuda.Show();
            this.Close();
        }
    }
}
