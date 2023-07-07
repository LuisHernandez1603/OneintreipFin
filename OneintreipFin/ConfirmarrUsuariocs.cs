using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace OneintreipFin
{
    public partial class ConfirmarUsuariocs : Form
    {
        public ConfirmarUsuariocs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted se ha registrado de manera exitosa regresando a pantalla de inicio", "Verificación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Inciodesesion inciodesesion = new Inciodesesion();
            inciodesesion.ShowDialog();
            this.Close();

        }


        private void ConfirmarUsuariocs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        } 
    }
}
