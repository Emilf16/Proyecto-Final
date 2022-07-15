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
    public partial class Ver_Reservaciones : Form
    {
        public Ver_Reservaciones()
        {
            InitializeComponent();
        }
        int m, mx, my;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Reservaciones_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }
        private void tbx_Nombre_Del_Jardin_Enter_1(object sender, EventArgs e)
        {
                if (tbx_Nombre_Del_Jardin.Text == "Nombre del Jardin")
                {
                    tbx_Nombre_Del_Jardin.Text = "";
                    tbx_Nombre_Del_Jardin.ForeColor = Color.White;
                }
        }

        private void tbx_Nombre_Del_Jardin_Leave_1(object sender, EventArgs e)
        {          
                if (tbx_Nombre_Del_Jardin.Text == "")
                {
                    tbx_Nombre_Del_Jardin.Text = "Nombre del Jardin";
                    tbx_Nombre_Del_Jardin.ForeColor = Color.White;
                }           
        }

        private void tbx_Longitud_Del_Jardin_Enter_1(object sender, EventArgs e)
        { 
            if (tbx_Longitud_Del_Jardin.Text == "Longitud del Jardin")
            {
                    tbx_Longitud_Del_Jardin.Text = "";
                    tbx_Longitud_Del_Jardin.ForeColor = Color.White;
            }
        }

        private void tbx_Longitud_Del_Jardin_Leave_1(object sender, EventArgs e)
        {
                if (tbx_Longitud_Del_Jardin.Text == "")
                {
                    tbx_Longitud_Del_Jardin.Text = "Longitud del Jardin";
                    tbx_Longitud_Del_Jardin.ForeColor = Color.White;
                }           
        }

        private void tbx_Descripcion_Del_Jardin_Leave_1(object sender, EventArgs e)
        {
                if (tbx_Descripcion_Del_Jardin.Text == "")
                {
                    tbx_Descripcion_Del_Jardin.Text = "Descripcion del Jardin";
                    tbx_Descripcion_Del_Jardin.ForeColor = Color.White;
                }
            
        }

        private void tbx_Descripcion_Del_Jardin_Enter_1(object sender, EventArgs e)
        {
                if (tbx_Descripcion_Del_Jardin.Text == "Descripcion del Jardin")
                {
                    tbx_Descripcion_Del_Jardin.Text = "";
                    tbx_Descripcion_Del_Jardin.ForeColor = Color.White;
                }
        }

        

       
    }
}
