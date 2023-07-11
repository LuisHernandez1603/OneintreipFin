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
    public partial class Asientos : Form
    {
        

    public Asientos()
    {
     InitializeComponent();
    }

        private Color originalColor;

        // Variable para almacenar el color original del botón
        private bool isRed = false; // Variable para almacenar el estado actual del botón



        private void button1_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button1.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button1.BackColor = originalColor;
                isRed = false;
            }
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            Random random =
 new
  Random();


            char
             randomLetter = (
            char
            )random.Next(
            'A'
            ,
            'Z'
             +
            1
            );

            int
             randomNumber = random.Next(
            100
            ,
            1000
            );


            string
             generatedCode =
            $"{ randomLetter}{ randomNumber} " ;

            TxtCode.Text = generatedCode;
        }

        private void Asientos_Load(object sender, EventArgs e)
        {
            //Guardar el color original del botón(verde)
            originalColor = button1.BackColor;
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

         
        private void button3_Click(object sender, EventArgs e)
        {

            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button3.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button3.BackColor = originalColor;
                isRed = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button2.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button2.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button6.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button6.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button5.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button5.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button4.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button4.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button12.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button12.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button10.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button10.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button11.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button11.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button7.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button7.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button8.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button8.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button9.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button9.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button21.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button21.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button18.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button18.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button20.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button20.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button16.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button16.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button15.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button15.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button17.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button17.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button19.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button19.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button13.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button13.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button14.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button14.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button27.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button27.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button25.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button25.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button23.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button23.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button26.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button26.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button24.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button24.BackColor = originalColor;
                isRed = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!isRed)
            {
                // Cambiar el color del botón a rojo
                button22.BackColor = Color.Red;
                isRed = true;
            }
            else
            {
                // Restaurar el color original del botón (verde)
                button22.BackColor = originalColor;
                isRed = false;
            }
        }
    }
}
