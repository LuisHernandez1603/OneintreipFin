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
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Hide();
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
            this.Close();
        }
    }
}
