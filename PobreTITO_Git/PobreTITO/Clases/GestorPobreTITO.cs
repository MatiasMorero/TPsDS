using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PobreTITO
{
    internal class GestorPobreTITO
    {
        private SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Matias Morero\Desktop\TPsDS\PobreTITO_Git\PobreTITO\BD\BD.mdf;Integrated Security=True");

        int id_persona;

        public void RegistrarPersona(string nombre, string apellido, DateOnly nacimiento, string telefono, string dni, string usuario, string email, string contraseña, string repetirContraseña)
        {
           
            Persona persona = new Persona(nombre, apellido, nacimiento, telefono, dni, usuario, email, contraseña, repetirContraseña);
            if(contraseña == repetirContraseña)
            {
                conexion.Open(); 
                persona.NuevaPersona(conexion);
                MessageBox.Show("Persona registrada");
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Contraseña distinta");
            }
           
        }

        public bool IniciarSesion(string usuario, string contraseña)
        {
            conexion.Open();
            SqlCommand iniciarSesion = new SqlCommand($"select Id, usuario, contraseña from Persona where usuario = '{usuario}'", conexion);
            SqlDataReader lector = iniciarSesion.ExecuteReader();
            if (lector.Read())
            {
                id_persona = lector.GetInt32(0);
                if(contraseña == lector.GetString(2))
                {
                    // MessageBox.Show("Sesion iniciada con exito");
                    conexion.Close(); 
                    return true;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
                conexion.Close();
                return false;
            }
            
        }

        public void RegistrarReclamo(string direccion, string descripcion, int subincidente)
        {
            conexion.Open();
            ReclamoClass reclamoClass = new ReclamoClass(direccion, descripcion);
            reclamoClass.NuevoReclamo(id_persona, subincidente, conexion);
            MessageBox.Show("Reclamo registrado");
            conexion.Close();
        }
    }

}
