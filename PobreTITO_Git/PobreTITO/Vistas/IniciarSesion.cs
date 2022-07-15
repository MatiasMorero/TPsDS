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
            bool condicion = Program.gestorPobreTITO.IniciarSesion(txt_UsuarioIS.Text, txt_ContraseñaIS.Text);
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

        private void txt_ContraseñaIS_Enter(object sender, EventArgs e)
        {
            if(txt_ContraseñaIS.Text == "Contraseña")
            {
                txt_ContraseñaIS.Text = "";
                txt_ContraseñaIS.ForeColor = Color.Black;
                txt_ContraseñaIS.UseSystemPasswordChar = true;
            }
        }

        private void txt_ContraseñaIS_Leave(object sender, EventArgs e)
        {
            if (txt_ContraseñaIS.Text == "")
            {
                txt_ContraseñaIS.Text = "Contraseña";
                txt_ContraseñaIS.ForeColor = Color.DimGray;
                txt_ContraseñaIS.UseSystemPasswordChar = false;
            }
        }

        // VALIDACIONES

        Validaciones validaciones = new Validaciones(); // Se crea objeto/instancia.

        private void txt_UsuarioIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarLetrasNumeros(e);
        }

        private void txt_ContraseñaIS_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_ContraseñaIS_TextChanged(object sender, EventArgs e){}

        
    }
}