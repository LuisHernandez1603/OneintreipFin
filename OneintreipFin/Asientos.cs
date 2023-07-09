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
        private Color originalColor; // Variable para almacenar el color original del botón
        private bool isRed = false; // Variable para almacenar el estado actual del bo
        

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
    }
}
