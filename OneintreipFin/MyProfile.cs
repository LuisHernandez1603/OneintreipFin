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

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
             DestinosTrip destinosTripForm
                = new DestinosTrip();
            destinosTripForm.Show();
            this.Close();
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
