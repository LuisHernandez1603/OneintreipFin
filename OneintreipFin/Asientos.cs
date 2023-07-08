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
    }
}
