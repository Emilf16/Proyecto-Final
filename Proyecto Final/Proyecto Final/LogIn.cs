namespace Proyecto_Final
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        int m,mx,my;


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tbx_Usuario_Enter(object sender, EventArgs e)
        {
            if(tbx_Usuario.Text == "Usuario")
            {
                tbx_Usuario.Text = "";
                tbx_Usuario.ForeColor = Color.Black;
            }
        }

        private void tbx_Usuario_Leave(object sender, EventArgs e)
        {
            if(tbx_Usuario.Text == "")
            {
                tbx_Usuario.Text = "Usuario";
                tbx_Usuario.ForeColor = Color.Black;
            }
        }

        private void tbx_Contraseña_Enter(object sender, EventArgs e)
        {
            if (tbx_Contraseña.Text == "Contraseña")
            {
                tbx_Contraseña.Text = "";
                tbx_Contraseña.ForeColor = Color.Black;
                tbx_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void tbx_Contraseña_Leave(object sender, EventArgs e)
        {
            if (tbx_Contraseña.Text == "")
            {
                tbx_Contraseña.Text = "Contraseña";
                tbx_Contraseña.ForeColor = Color.Black;
                tbx_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            var RegistroForm = new Registro();
            RegistroForm.ShowDialog();
            this.Close();
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
    }
}