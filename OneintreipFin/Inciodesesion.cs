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
        string usuario = "messi22@gmail.com";
        string contraseña = "messigoat";
        public Inciodesesion()
        {
            InitializeComponent();
        }

        private void Inciodesesion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != usuario || txtUser.Text != contraseña)
            {

                if (txtUser.Text != usuario)
                {
                    MessageBox.Show("Usuario Incorrecto");
                    txtUser.Clear();
                    txtUser.Focus();
                    return;
                }
                if (txtpass.Text != contraseña)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    txtpass.Clear();
                    txtpass.Focus();
                    return;


                }

            }
            else
            {
                txtUser.Clear();
                txtpass.Clear();
                Inciodesesion form = new Inciodesesion();
                form.ShowDialog();

            }
            this.Hide();
            DestinosTrip destinosTrip = new DestinosTrip();
            destinosTrip.Show();
           

          
        }

        private void CrearC_Click(object sender, EventArgs e)
        {
            //Ingresar ala ventana de seleccion de destino}

            this.Hide();
            CrearCuenta crearCuenta = new CrearCuenta();
            crearCuenta.ShowDialog();
        }
    }
}
