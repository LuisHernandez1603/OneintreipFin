using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneintreipFin
{
    public partial class Inciodesesion : Form
    {
        
        public Inciodesesion()
        {
            InitializeComponent();
        }

        private void Inciodesesion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string
              basePath = Directory.GetCurrentDirectory();
            string filePath = basePath.Replace(@"\bin\Debug", @"\file\RegistroUsuario.txt");

            string username = txtUser.Text;
            string password = txtpass.Text;

            bool validUser =
            false
            ;

            try

            {

                string
                [] lines = File.ReadAllLines(filePath);


                foreach
                 (string line in lines)
                {

                    string
                    [] fields = line.Split(
                    ';'
                    );

                    if
                     (fields.Length >= 2 && fields[0] == username && fields[1] == password)
                    {
                        validUser = true; break;
                    }
                }
            }
            catch
             (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if
             (validUser)
            {
                MessageBox.Show("Sesión iniciada correctamente. ¡Bienvenido!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DestinosTrip InicioDeSecionForm =
            new
              DestinosTrip ();
                InicioDeSecionForm.Show();

                this
                .Hide();
            }
            else

            {
                MessageBox.Show("Usuario no válido", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void CrearC_Click(object sender, EventArgs e)
        {
            //Ingresar ala ventana de seleccion de destino}

            this.Hide();
            CrearCuenta crearCuenta = new CrearCuenta();
            crearCuenta.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
