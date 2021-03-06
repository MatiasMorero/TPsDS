namespace PobreTITO
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            bool condicion = Program.gestorPobreTITO.IniciarSesion(txt_UsuarioIS.Text, txt_ContraseņaIS.Text);
            if (condicion)
            {
                Menu menu = new Menu();
                menu.ShowDialog();
                this.Hide(); //Minimiza
            }
        }

        private void btn_Registrate_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.ShowDialog();
        }

        // MARCAS DE AGUA (WATERMARK)

        private void txt_UsuarioIS_Enter(object sender, EventArgs e)
        {
            if (txt_UsuarioIS.Text == "Usuario")
            {
                txt_UsuarioIS.Text = "";
                txt_UsuarioIS.ForeColor = Color.Black;
            }
        }

        private void txt_UsuarioIS_Leave(object sender, EventArgs e)
        {
            if (txt_UsuarioIS.Text == "")
            {
                txt_UsuarioIS.Text = "Usuario";
                txt_UsuarioIS.ForeColor = Color.DimGray;
            }
        }

        private void txt_ContraseņaIS_Enter(object sender, EventArgs e)
        {
            if(txt_ContraseņaIS.Text == "Contraseņa")
            {
                txt_ContraseņaIS.Text = "";
                txt_ContraseņaIS.ForeColor = Color.Black;
                txt_ContraseņaIS.UseSystemPasswordChar = true;
            }
        }

        private void txt_ContraseņaIS_Leave(object sender, EventArgs e)
        {
            if (txt_ContraseņaIS.Text == "")
            {
                txt_ContraseņaIS.Text = "Contraseņa";
                txt_ContraseņaIS.ForeColor = Color.DimGray;
                txt_ContraseņaIS.UseSystemPasswordChar = false;
            }
        }

        // VALIDACIONES

        Validaciones validaciones = new Validaciones(); // Se crea objeto/instancia.

        private void txt_UsuarioIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarLetrasNumeros(e);
        }

        private void txt_ContraseņaIS_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_ContraseņaIS_TextChanged(object sender, EventArgs e){}

        
    }
}