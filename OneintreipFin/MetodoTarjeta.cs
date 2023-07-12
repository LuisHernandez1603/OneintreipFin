using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OneintreipFin
{
    public partial class MetodoTarjeta : Form

    {
        public MetodoTarjeta()
        {
            InitializeComponent();
        }

        private void MetodoTarjeta_Load(object sender, EventArgs e)
        {
            combotarjetas.Items.Add("LAFISE");
            combotarjetas.Items.Add("BANPRO");
            combotarjetas.Items.Add("BAC");
        }

        private void guardart_Click(object sender, EventArgs e)
        {
            if (txtNumeroTarjeta.Text == "1234567890" && txtcvv.Text == "123" && txtexp.Text == "03/27")
            {


                MessageBox.Show("¡Pago exitoso!", "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Asientos asientos = new Asientos();
                asientos.Show();
            }
            else
            {
                MessageBox.Show("El pago no pudo ser procesado. Por favor, verifique los detalles de su tarjeta.", "Pago fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           


        }

        


        private void combotarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoSeguridad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void txtFechaExpiracion_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtexp_TextChanged(object sender, EventArgs e)
        {
            string fechaExpiracion = txtexp.Text;

            if (fechaExpiracion == "07/23")
            {
                // Código a ejecutar si la fecha de expiración es válida
                Console.WriteLine("Fecha de expiración válida");
                
            }
            else
            {
                // Código a ejecutar si la fecha de expiración no es válida
                Console.WriteLine("Fecha de expiración inválida");
                
            }

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
            this.Close();
        }
    }
}
