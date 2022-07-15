using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PobreTITO
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {  
            Program.gestorPobreTITO.RegistrarPersona(txt_Nombre.Text,txt_Apellido.Text,DateOnly.Parse(txt_Nacimiento.Text),txt_Telefono.Text,txt_Dni.Text,txt_Usuario.Text,txt_Email.Text,txt_Contraseña.Text,txt_repetirContraseña.Text);
        } 

        private void txt_Nombre_TextChanged(object sender, EventArgs e){}

        // MARCAS DE AGUA (WATERMARK)

        private void txt_Nombre_Enter(object sender, EventArgs e) // Cursor dentro del txt 
        {
            if (txt_Nombre.Text == "Nombre")
            {
                txt_Nombre.Text = "";
                txt_Nombre.ForeColor = Color.Black;
            }
        }

        private void txt_Nombre_Leave(object sender, EventArgs e) // Cursor sale del txt
        {
            if(txt_Nombre.Text == "")
            {
                txt_Nombre.Text = "Nombre";
                txt_Nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_Apellido_Enter(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "Apellido")
            {
                txt_Apellido.Text = "";
                txt_Apellido.ForeColor = Color.Black;
            }
        }

        private void txt_Apellido_Leave(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "")
            {
                txt_Apellido.Text = "Apellido";
                txt_Apellido.ForeColor = Color.DimGray;
            }
        }

        private void txt_Nacimiento_Enter(object sender, EventArgs e)
        {
            if (txt_Nacimiento.Text == "Nacimiento (dd/mm/aaaa)")
            {
                txt_Nacimiento.Text = "";
                txt_Nacimiento.ForeColor = Color.Black;
            }
        }

        private void txt_Nacimiento_Leave(object sender, EventArgs e)
        {
            if (txt_Nacimiento.Text == "")
            {
                txt_Nacimiento.Text = "Nacimiento (dd/mm/aaaa)";
                txt_Nacimiento.ForeColor = Color.DimGray;
            }
        }

        private void txt_Telefono_Enter(object sender, EventArgs e)
        {
            if (txt_Telefono.Text == "Telefono (ccccxxxxxx)")
            {
                txt_Telefono.Text = "";
                txt_Telefono.ForeColor = Color.Black;
            }
        }

        private void txt_Telefono_Leave(object sender, EventArgs e)
        {
            if (txt_Telefono.Text == "")
            {
                txt_Telefono.Text = "Telefono (ccccxxxxxx)";
                txt_Telefono.ForeColor = Color.DimGray;
            }
        }

        private void txt_Dni_Enter(object sender, EventArgs e)
        {
            if (txt_Dni.Text == "Dni")
            {
                txt_Dni.Text = "";
                txt_Dni.ForeColor = Color.Black;
            }
        }

        private void txt_Dni_Leave(object sender, EventArgs e)
        {
            if (txt_Dni.Text == "")
            {
                txt_Dni.Text = "Dni";
                txt_Dni.ForeColor = Color.DimGray;
            }
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "Usuario")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.Black;
            }
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "Usuario";
                txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if (txt_Email.Text == "Email (ejemplo@gmail.com)")
            {
                txt_Email.Text = "";
                txt_Email.ForeColor = Color.Black;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                txt_Email.Text = "Email (ejemplo@gmail.com)";
                txt_Email.ForeColor = Color.DimGray;
            }
        }

        private void txt_Contraseña1_Enter(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "Contraseña")
            {
                txt_Contraseña.Text = "";
                txt_Contraseña.ForeColor = Color.Black;
                txt_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contraseña1_Leave(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "")
            {
                txt_Contraseña.Text = "Contraseña";
                txt_Contraseña.ForeColor = Color.DimGray;
                txt_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void txt_Contraseña2_Enter(object sender, EventArgs e)
        {
            if (txt_repetirContraseña.Text == "Repetir Contraseña")
            {
                txt_repetirContraseña.Text = "";
                txt_repetirContraseña.ForeColor = Color.Black;
                txt_repetirContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contraseña2_Leave(object sender, EventArgs e)
        {
            if (txt_repetirContraseña.Text == "")
            {
                txt_repetirContraseña.Text = "Repetir Contraseña";
                txt_repetirContraseña.ForeColor = Color.DimGray;
                txt_repetirContraseña.UseSystemPasswordChar = false;
            }
        } 

        // VALIDACIONES

        Validaciones validaciones = new Validaciones(); // Se crea objeto/instancia.

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarLetras(e);
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarLetras(e);
        }

        private void txt_Nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarNumerosFecha(e);
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarNumeros(e);
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarNumeros(e);
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarLetrasNumeros(e);
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_repetirContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
