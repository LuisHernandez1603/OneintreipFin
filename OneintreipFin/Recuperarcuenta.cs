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
    public partial class Recuperarcuenta : Form
    {
        public Recuperarcuenta()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {


                foreach (Form form in Application.OpenForms)
                {
                    form.Hide();

                }
                Application.Exit();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correo electronico valido", "Recuperar correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Mensajedeconfirmación mensajedeconfirmación = new Mensajedeconfirmación();
            mensajedeconfirmación.Show();
            this.Close();
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
