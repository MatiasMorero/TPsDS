using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    // Clase Abstracta o Interfaz
    public abstract class AbstractProduct
    {
        // Caracteristicas minimas de un producto
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public AbstractProduct(string Nombre, double Precio)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
        }
    }
}
