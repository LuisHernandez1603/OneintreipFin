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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodoTarjeta metodoTarjeta = new MetodoTarjeta();
            metodoTarjeta.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProfile usuario = new MyProfile();
            usuario.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Asientos asientos = new Asientos();
            asientos.Show();
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda ayuda = new Ayuda();
            ayuda.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DestinosTrip destinosTrip = new DestinosTrip();
            destinosTrip.Show();
            
        }
    }
}
