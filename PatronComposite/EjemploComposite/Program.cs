using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Porductos Simples

            SimpleProduct ram4gb = new SimpleProduct("Memoria RAM 4GB", 3000, "KingStone");
            SimpleProduct ram8gb = new SimpleProduct("Memoria RAM 8GB", 5000, "KingStone");

            SimpleProduct ssd500gb = new SimpleProduct("Disco Sólido 500GB", 6500, "GIGABYTE");
            SimpleProduct ssdk1tb = new SimpleProduct("Disco Sólido 1TB", 10000, "GIGABYTE");

            SimpleProduct cpuAMD = new SimpleProduct("AMD phenon", 7000, "AMD");
            SimpleProduct cpuIntel = new SimpleProduct("Intel i7", 15000, "Intel");

            SimpleProduct gabineteChico = new SimpleProduct("Gabinete Pequeño", 85000, "MAGNUMtech");
            SimpleProduct gabineteGrande = new SimpleProduct("Gabinete Grande", 10000, "MAGNUMtech");

            SimpleProduct monitor20pulgadas = new SimpleProduct("Monitor 20'", 35000, "HP");
            SimpleProduct monitor30pulgadas = new SimpleProduct("Monitor 30'", 50000, "HP");

             // Paquete: Componentes para PC que incluye procesador Intel i7, ssd de 1TB y ram de 8gb.
            CompositeProduct Componentes = new CompositeProduct("Paq.Componentes");
            Componentes.AgregarProducto(cpuIntel);
            Componentes.AgregarProducto(ram8gb);
            Componentes.AgregarProducto(ssdk1tb);

            SaleOrder PC = new SaleOrder(1, "Matias Morero");
            PC.AgregarProducto(Componentes); //Paquete
            PC.AgregarProducto(gabineteGrande); //Producto
            PC.AgregarProducto(monitor30pulgadas); //Producto
            PC.imprimirOrden();

            Console.ReadKey();
        }
    }
}
