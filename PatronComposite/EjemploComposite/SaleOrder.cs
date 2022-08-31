using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    public class SaleOrder
    {
        private long ordenId { get; set; }
        private string cliente { get; set; }

        private ArrayList productos = new ArrayList();

    public SaleOrder(long ordenId, string cliente)
        {
            this.ordenId = ordenId;
            this.cliente = cliente;
        }

        // Regresa el precio total de la orden

        public double PrecioTotal
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

        // Agregar o Eliminar productos de una ORDEN

        public void AgregarProducto(AbstractProduct producto)
        {
            productos.Add(producto);
        }

        public void EliminarProducto(AbstractProduct producto)
        {
            productos.Remove(producto);
        }

        public void imprimirOrden()
        {
            Console.WriteLine("\n=============================================\nOrden: " + ordenId + "\nCliente: " + cliente + "\nProductos:");
            foreach (AbstractProduct producto in productos)
            {
                if (producto.GetType().Name == "CompositeProduct")
                    Console.WriteLine(" > " + producto.Nombre + " Precio: $" + ((CompositeProduct)producto).Precio);
                else
                    Console.WriteLine(" > " + producto.Nombre + " Precio: $" + producto.Precio);
            }
            Console.WriteLine("Total: $" + PrecioTotal + "\n=============================================");
        }
    }
}
