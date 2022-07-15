using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PobreTITO
{
    internal class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateOnly nacimiento { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }
        public string usuario { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
        public string repetirContraseña { get; set; }

        public Persona(string nombre, string apellido, DateOnly nacimiento, string telefono, string dni, string usuario, string email, string contraseña , string repetirContraseña)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.telefono = telefono;
            this.dni = dni;
            this.usuario = usuario;
            this.email = email;
            this.contraseña = contraseña;
            this.repetirContraseña = repetirContraseña;
        }

        public void NuevaPersona(SqlConnection connection)
        {
            SqlCommand insert = new SqlCommand($"insert into Persona values('{nombre + " " + apellido}','{nacimiento}','{telefono}','{dni}','{usuario}','{email}','{contraseña}')", connection);
            insert.ExecuteNonQuery();
        }
    }

    
}
