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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;

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
            txtselectU.SelectedIndex = 0; //SELECCIONAR EL PRIMER ELEMNTO DEL COMBOBOX
            

        }
        private bool datosValidos()
        {
            // Aquí debes implementar la lógica de validación de los datos de registro
            // Puedes verificar que los campos estén completos, que cumplan con ciertos formatos, etc.

            // Ejemplo de validación simple
            if (txtcel.Text == "")
            {
                return false; // Datos incorrectos si el campo de nombre está vacío
            }

            return true; // Si todos los datos son válidos, retorna true



        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter writerFile; //Objeto para manejar la escritura que permita el fichero
            string Line; //Varible por medio de la cual se tomaran los datos a escribir

            //determinar donde se encuentra el directorio raiz de la aplicación
            string basePath = Directory.GetCurrentDirectory();
            string filePath = basePath.Replace(@"\bin\Debug", @"\file\RegistroUsuario.txt");
            fs = new FileStream(filePath, FileMode.Append);

            //Crear el objeto para la escritura en el archivo
            writerFile = new StreamWriter(fs);
            //Proceder con el guardado de los datons en el formulario
            Line = txtname.Text + ";";
            Line += txtlastname.Text + ";";
            Line += txtnum.Text + ";";
            Line += txtcel.Text + ";";
            Line += txtsexo.Text + ";";

            Line += txtselectU.SelectedItem as string;


            writerFile.WriteLine(Line.ToUpper());
            writerFile.Close();

            MessageBox.Show("El Registro se \n ha completado", "Guardar Registro"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);

             DestinosTrip CrearCuentaForm =
       new
          DestinosTrip ();
            CrearCuentaForm.Show();


            this
            .Close();

        }


        private void maskedb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inciodesesion inciodesesion = new Inciodesesion ();
            inciodesesion.Show();
            this .Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FileStream fs; //preparar un objeto que permita modifiacra el fichero
            StreamWriter writerFile; //Objeto para manejar la excritura en el fichero
            string line; //variable por medio de la cual se tomaran los datos a escribir

            //determinar donde se encuentra el directorio raiz de la aplicacion

            string basePath = Directory.GetCurrentDirectory();
            //definir la ruta ddonde se va crear el archivo

            // string filePath = basePath.Replace("\\bin\\Debug", "\\file\\inputProducts"); por si no reconoce el arroba
            string filePath = basePath.Replace(@"\bin\Debug", @"\file\RegistroUsuario.txt");
            //crear el objeto que nos permite trabajar con el archivo

            fs = new FileStream(filePath, FileMode.Append);

            //crear el objeto para la escritura en el archivo

            writerFile = new StreamWriter(fs);

            //procedemos con el guarddado del los datos en el formualario
            line = txtname.Text + ";";// tomar el texto que esta en el control TxtCode
            line += txtlastname.Text + ";";//unir el contenido de line con el de la caja de texto
            line += txtnum.Text + ";";
            line += txtselectU.Text + ";";
            line += txtcel.Text + ";";
            line += txtsexo.Text + ";";
            line += txtselectU.SelectedItem as string; //tomar como cadena el valor del combo

            //escribir en el archivo lo que se tiene captutrado en la variable line
            writerFile.WriteLine(line.ToUpper()); //pasar a mayuscula todo el texto
            writerFile.Close();//cerrae el archivo y escribir la salida

            MessageBox.Show("El Producto se \n ha guardado", "Guardar Producto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }//fin de guardar

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

        private void txtselectT_SelectedIndexChanged(object sender, EventArgs e)
        {

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
