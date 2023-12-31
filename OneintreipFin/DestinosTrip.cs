﻿using System;
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
    public partial class DestinosTrip : Form
    {
        public DestinosTrip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                this.Hide();
            Horariostripcs horariostripcs = new Horariostripcs();
            horariostripcs.Show();
            this.Close();

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inciodesesion inciodesesion = new Inciodesesion();
            inciodesesion.Show();  
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
            this.Close();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Horariostripcs horariostripcsForm
                = new Horariostripcs();
            horariostripcsForm.Show();
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda ayuda = new Ayuda();
            ayuda.Show();
            this.Close();
        }

        private void DestinosTrip_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Horariostripcs horariostripcs = new Horariostripcs();
            horariostripcs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Horariostripcs horariostripcs = new Horariostripcs();
            horariostripcs.Show();
        }
    }
}
