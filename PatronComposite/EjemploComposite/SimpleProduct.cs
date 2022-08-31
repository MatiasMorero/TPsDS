using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    // SimpleProduct extiende o es heredado por AbstractProduct (para que sean tratados de igual manera)
    public class SimpleProduct : AbstractProduct
    {
        // Agregamos un atributo que solo un producto simple pueda tener
        public string Marca { get; set; }

        public SimpleProduct(string Nombre, double Precio, string Marca) : base(Nombre, Precio)
        {
            this.Marca = Marca;
        }
    }
}
