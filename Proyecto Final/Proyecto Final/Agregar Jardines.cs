using System;
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
    public partial class Agregar_Jardines : Form
    {
        public Agregar_Jardines()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Descripcion_Del_Jardin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Nombre_Del_Jardin_Enter(object sender, EventArgs e)
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

        private void tbx_Longitud_Del_Jardin_Enter(object sender, EventArgs e)
        {
            if (tbx_Longitud_Del_Jardin.Text == "Longitud del Jardin")
            {
                tbx_Longitud_Del_Jardin.Text = "";
                tbx_Longitud_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Longitud_Del_Jardin_Leave(object sender, EventArgs e)
        {
            if (tbx_Longitud_Del_Jardin.Text == "")
            {
                tbx_Longitud_Del_Jardin.Text = "Longitud del Jardin";
                tbx_Longitud_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Descripcion_Del_Jardin_Enter(object sender, EventArgs e)
        {
            if (tbx_Descripcion_Del_Jardin.Text == "Descripcion del Jardin")
            {
                tbx_Descripcion_Del_Jardin.Text = "";
                tbx_Descripcion_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Descripcion_Del_Jardin_Leave(object sender, EventArgs e)
        {
            if (tbx_Descripcion_Del_Jardin.Text == "")
            {
                tbx_Descripcion_Del_Jardin.Text = "Descripcion del Jardin";
                tbx_Descripcion_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
