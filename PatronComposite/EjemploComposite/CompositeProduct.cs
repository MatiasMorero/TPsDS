using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    // CompositeProduct extiende o es heredado por AbstractProduct (para que sean tratados de igual manera)
    class CompositeProduct : AbstractProduct
    {
        private List<AbstractProduct> productos = new List<AbstractProduct>();

        public CompositeProduct(string Nombre, double Precio=0) : base(Nombre, Precio)
        {

        }

        // Regresa el precio de todos los productos que contiene el paquete
        public new double Precio
        {
            get
            {
                double precio = 0;
                foreach (AbstractProduct producto in productos)
                {
                    if (producto.GetType().Name == "CompositeProduct")
                        precio += ((CompositeProduct)producto).Precio;
                    else
                        precio += producto.Precio;
                }
                return precio;
            }
        }

        // Agregar o Eliminar productos de un PAQUETE

        public void AgregarProducto(AbstractProduct producto)
        {
            productos.Add(producto);
        }

        public void EliminarProducto(AbstractProduct producto)
        {
            productos.Remove(producto);
        }
    }
}
