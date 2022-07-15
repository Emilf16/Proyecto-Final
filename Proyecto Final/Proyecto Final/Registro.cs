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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        int m, mx, my;
        private void tbx_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void tbx_Nombre_Enter(object sender, EventArgs e)
        {
            if (tbx_Nombre.Text == "Nombre")
            {
                tbx_Nombre.Text = "";
                tbx_Nombre.ForeColor = Color.White;
            }
        }

        private void tbx_Nombre_Leave(object sender, EventArgs e)
        {
            if (tbx_Nombre.Text == "")
            {
                tbx_Nombre.Text = "Nombre";
                tbx_Nombre.ForeColor = Color.White;
            }
        }

        private void tbx_Apellido_Enter(object sender, EventArgs e)
        {
            if (tbx_Apellido.Text == "Apellido")
            {
                tbx_Apellido.Text = "";
                tbx_Apellido.ForeColor = Color.White;
            }
        }

        private void tbx_Apellido_Leave(object sender, EventArgs e)
        {
            if (tbx_Apellido.Text == "")
            {
                tbx_Apellido.Text = "Apellido";
                tbx_Apellido.ForeColor = Color.White;
            }
        }

        private void tbx_Usuario_Enter(object sender, EventArgs e)
        {
            
                
            if (tbx_Usuario.Text == "Nombre de Usuario")
            {
                tbx_Usuario.Text = "";
                tbx_Usuario.ForeColor = Color.White;
                
            }
        }

        private void tbx_Usuario_Leave(object sender, EventArgs e)
        {
            if (tbx_Usuario.Text == "")
            {
                tbx_Usuario.Text = "Nombre de Usuario";
                tbx_Usuario.ForeColor = Color.White;

            }
        }

        private void tbx_Contraseña_Enter(object sender, EventArgs e)
        {
            if (tbx_Contraseña.Text == "Contraseña")
            {
                tbx_Contraseña.Text = "";
                tbx_Contraseña.ForeColor = Color.White;

            }
        }

        private void tbx_Contraseña_Leave(object sender, EventArgs e)
        {
            if (tbx_Contraseña.Text == "")
            {
                tbx_Contraseña.Text = "Contraseña";
                tbx_Contraseña.ForeColor = Color.White;

            }
        }

        private void tbx_Confirmar_Contraseña_Enter(object sender, EventArgs e)
        {
            if (tbx_Confirmar_Contraseña.Text == "Confirmar Contraseña")
            {
                tbx_Confirmar_Contraseña.Text = "";
                tbx_Confirmar_Contraseña.ForeColor = Color.White;

            }
        }
        private void tbx_Confirmar_Contraseña_Leave(object sender, EventArgs e)
        {
            if (tbx_Confirmar_Contraseña.Text == "")
            {
                tbx_Confirmar_Contraseña.Text = "Confirmar Contraseña";
                tbx_Confirmar_Contraseña.ForeColor = Color.White;

            }
        }

        private void tbx_Correo_Electronico_Enter(object sender, EventArgs e)
        {
            if (tbx_Correo_Electronico.Text == "Correo Electronico")
            {
                tbx_Correo_Electronico.Text = "";
                tbx_Correo_Electronico.ForeColor = Color.White;

            }
        }

        private void tbx_Correo_Electronico_Leave(object sender, EventArgs e)
        {
            if (tbx_Correo_Electronico.Text == "")
            {
                tbx_Correo_Electronico.Text = "Correo Electronico";
                tbx_Correo_Electronico.ForeColor = Color.White;

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void tbx_Pregunta_De_Seguridad_Enter(object sender, EventArgs e)
        {
            if (tbx_Pregunta_De_Seguridad.Text == "Nombre del primer libro que leiste")
            {
                tbx_Pregunta_De_Seguridad.Text = "";
                tbx_Pregunta_De_Seguridad.ForeColor = Color.White;

            }
        }

        private void tbx_Pregunta_De_Seguridad_Leave(object sender, EventArgs e)
        {
            if (tbx_Pregunta_De_Seguridad.Text == "")
            {
                tbx_Pregunta_De_Seguridad.Text = "Nombre del primer libro que leiste";
                tbx_Pregunta_De_Seguridad.ForeColor = Color.White;

            }
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
