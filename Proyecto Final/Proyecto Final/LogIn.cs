namespace Proyecto_Final
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        int m,mx,my;//variables que permiten el movimiento del form


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var prueba = new Cliente();
            prueba.Show();
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

        private void tbx_Contraseņa_Enter(object sender, EventArgs e)
        {
            if (tbx_Contraseņa.Text == "Contraseņa")
            {
                tbx_Contraseņa.Text = "";
                tbx_Contraseņa.ForeColor = Color.Black;
                tbx_Contraseņa.UseSystemPasswordChar = true;
            }
        }

        private void tbx_Contraseņa_Leave(object sender, EventArgs e)
        {
            if (tbx_Contraseņa.Text == "")
            {
                tbx_Contraseņa.Text = "Contraseņa";
                tbx_Contraseņa.ForeColor = Color.Black;
                tbx_Contraseņa.UseSystemPasswordChar = false;
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
            Application.Exit();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            var openregistro = new Registro();
            openregistro.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Btn_Acceder_Click(object sender, EventArgs e)
        {
            var admintest = new Administrador();
            admintest.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_MouseDown_1(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
            
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void tbx_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox3_MouseUp_1(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        
    }
}