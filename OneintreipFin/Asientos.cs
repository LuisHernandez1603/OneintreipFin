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
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);



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
            MessageBox.Show("Codigo generado.", "Codigo de reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            Despedida despedida = new Despedida();
            despedida.Show();
            this.Close();
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

            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva No Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva No Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ha sido reservado exitosamente.", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este asiento ya ha sido reservado", "Asiento No Reservado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
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
