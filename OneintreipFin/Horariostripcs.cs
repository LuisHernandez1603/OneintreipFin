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
    public partial class Horariostripcs : Form
    {
        public Horariostripcs()
        {
            InitializeComponent();
        }

        private void Horariostripcs_Load(object sender, EventArgs e)
        {
            Horarios.Items.Add("6:00");
            Horarios.Items.Add("6:10");
            Horarios.Items.Add("6:20");
            Horarios.Items.Add("6:30");
            Horarios.Items.Add("6:40");
            Horarios.Items.Add("6:50");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
