﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Modificar_Citas : Form
    {
        public Modificar_Citas()
        {
            InitializeComponent();
        }
        int m, mx, my;//variables que permiten el movimiento del form
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Disponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void dgv_No_Disponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Jardin.Text == "Nombre del Jardin")
            {
                tbx_Nombre_Del_Jardin.Text = "";
                tbx_Nombre_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Nombre_Del_Jardin_Leave(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Jardin.Text == "")
            {
                tbx_Nombre_Del_Jardin.Text = "Nombre del Jardin";
                tbx_Nombre_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Nombre_Del_Usuario_Enter(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Usuario.Text == "Nombre del Usuario")
            {
                tbx_Nombre_Del_Usuario.Text = "";
                tbx_Nombre_Del_Usuario.ForeColor = Color.White;
            }
        }

        private void tbx_Nombre_Del_Usuario_Leave(object sender, EventArgs e)
        {
            if (tbx_Nombre_Del_Usuario.Text == "")
            {
                tbx_Nombre_Del_Usuario.Text = "Nombre del Usuario";
                tbx_Nombre_Del_Usuario.ForeColor = Color.White;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
