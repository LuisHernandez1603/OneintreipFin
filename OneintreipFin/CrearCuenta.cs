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
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void numerotel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numerocel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            selecU.Items.Add("Universitario");
            selecU.Items.Add("Cuidadano");

        }
        private bool datosValidos()
        {
            // Aquí debes implementar la lógica de validación de los datos de registro
            // Puedes verificar que los campos estén completos, que cumplan con ciertos formatos, etc.

            // Ejemplo de validación simple
            if (numerocel.Text == "")
            {
                return false; // Datos incorrectos si el campo de nombre está vacío
            }

            return true; // Si todos los datos son válidos, retorna true



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string numerotel = this.numerotel.Text;
            if (numerotel[0] == '+' && numerotel[1] == '5' && numerotel[2] == '0' && numerotel[3] == '5')
            {
                MessageBox.Show("Número de teléfono nicaragüense válido.", "Verificación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Número de teléfono incorrecto. Por favor, ingrese un número de teléfono nicaragüense válido.", "Verificación fallida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            this.Hide();
            ConfirmarUsuariocs confirmarUsuariocs = new ConfirmarUsuariocs();
            confirmarUsuariocs.ShowDialog();

        }

        private void maskedb_Click(object sender, EventArgs e)
        {
            numerotel.Clear();
        }
    }
}
