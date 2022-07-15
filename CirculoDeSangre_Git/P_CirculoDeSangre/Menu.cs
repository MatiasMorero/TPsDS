using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Menu
    {
        int caso = 9;
        public void IniciarPrograma(Socio socio, List<Socio> ListaDeSocios, BancoDeSangre bds, Peticion peticion, Donacion donacion, List<Peticion> ListaDePeticiones,
            SocioAsignado sa, Menu menu, ValidarSocio vs, List<SocioAsignado> SociosAsignados, ValidarPeticion vp, ValidarDonacion vd)
        {
            do
            {
                switch (caso)
                {
                    case 9:
                        Console.Write("Bienvenidos Al Circulo De Sangre RH-\n");
                        Console.WriteLine("1 -> Iniciar Sesion como socio.");
                        Console.WriteLine("2 -> Registrarse como socio.");
                        Console.WriteLine("3 -> Iniciar Sesion como Banco de Sangre.");
                        Console.WriteLine("4 -> Ingresar como Administrador.");
                        Console.WriteLine("0 -> Finalizar Programa.");
                        int opcion;
                        do
                        {
                            Console.Write("Elija una opcion: ");
                            opcion = Convert.ToInt32(Console.ReadLine());
                        } while (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4 && opcion != 0);

                        switch (opcion)
                        {
                            case 0:
                                Environment.Exit(0);
                                break;

                            case 1:
                                socio.IniciarSesion(menu);
                                break;

                            case 2:
                                socio.RegistrarDatosDeLaPersona(vs);
                                Console.WriteLine("Socio registrado correctamente.");

                                Console.WriteLine("9 -> Volver al inicio.");
                                Console.WriteLine("0 -> Finalizar Programa.");
                                do
                                {
                                    Console.Write("Elija una opcion: ");
                                    caso = Convert.ToInt32(Console.ReadLine());
                                } while (caso != 9 && caso != 0);
                                break;

                            case 3:
                                bds.IniciarSesionBds(peticion, sa, donacion, ListaDeSocios, ListaDePeticiones, menu, SociosAsignados, vp, vd);
                                break;

                            case 4:
                                Vopc();
                                void Vopc()
                                {
                                    Console.WriteLine("1 -> Mostrar Listado de Socios.");
                                    Console.WriteLine("2 -> Mostrar Listado de Peticiones.");
                                    Console.WriteLine("3 -> Mostrar Listado de Donaciones.");
                                    Console.WriteLine("4 -> Mostrar Listado de Bancos de Sangre.");
                                    Console.WriteLine("9 -> Para Volver al Menú");
                                    int m;
                                    do
                                    {
                                        Console.Write("Elija una opcion: ");
                                        m = Convert.ToInt32(Console.ReadLine());
                                    } while (m != 1 && m != 2 && m != 3 && m != 4 && m != 9);

                                    switch (m)
                                    {
                                        case 1:
                                            socio.MostrarListado();
                                            KeyToReturn();
                                            Vopc();
                                            break;

                                        case 2:
                                            peticion.MostrarPeticiones();
                                            KeyToReturn();
                                            Vopc();
                                            break;

                                        case 3:
                                            donacion.MostrarListaDeDonaciones();
                                            KeyToReturn();
                                            Vopc();
                                            break;

                                        case 4:
                                            bds.MostrarListaDeBancos();
                                            KeyToReturn();
                                            Vopc();
                                            break;

                                        case 9:
                                            caso = 9;
                                            break;
                                    }

                                }
                                break;
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (caso != 0);
        }
        public void KeyToReturn()
        {
            Console.WriteLine("\nPresione Enter para volver.\n");
            Console.ReadLine();
        }
    }
}
