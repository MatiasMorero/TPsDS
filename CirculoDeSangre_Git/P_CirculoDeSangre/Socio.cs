using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Socio
    {
        //ATRIBUTOS 

        private string grupoSanguineo;
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime fechaDeNacimiento;
        private string domicilio;
        private string localidad;
        private string telefono;
        private string categoria; // activo | pasivo
        private bool enfermedad;
        private bool tomaMedicacion;
        private string medicamento;
        private string email;
        private string contraseña;
        private DateTime fechaDeUltimaDonacion;
        private string condicion; // disponible | nodisponible
        private int cantDeDonaciones;
        private List<Socio> listaDeSocios = new List<Socio>(); // lista de socios

        //CAMPOS ENCAPSULADOS 

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string GrupoSanguineo { get => grupoSanguineo; set => grupoSanguineo = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public bool Enfermedad { get => enfermedad; set => enfermedad = value; }
        public bool TomaMedicacion { get => tomaMedicacion; set => tomaMedicacion = value; }
        public string Medicamento { get => medicamento; set => medicamento = value; }
        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime FechaDeUltimaDonacion { get => fechaDeUltimaDonacion; set => fechaDeUltimaDonacion = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        public int CantDeDonaciones { get => cantDeDonaciones; set => cantDeDonaciones = value; }
        public List<Socio> ListaDeSocios { get => listaDeSocios; set => listaDeSocios = value; }


        //METODOS


        //SOCIOS REGISTRADOS PREVIAMENTE
        public void SociosYaRegistrados()
        {
            //SOCIO 1 ( A- | activo)
            ListaDeSocios.Add(new Socio()
            {
                Nombre = "Matias",
                Apellido = "Morero",
                Dni = 42560289,
                GrupoSanguineo = "A-",
                FechaDeNacimiento = new DateTime(2000, 08, 08),
                Domicilio = "Cabrera 3906",
                Localidad = "San Francisco",
                Telefono = "3406-462903",
                Enfermedad = false,
                TomaMedicacion = false,
                Medicamento = "-",
                Email = "matiasmorero10@gmail.com",
                Contraseña = "mati123",
                Categoria = "activo",
                FechaDeUltimaDonacion = new DateTime(2000, 1, 1),
                cantDeDonaciones = 0,
                Condicion = "disponible"
            });
        }

        //INICIAR SESION
        public string isEmail;
        public void IniciarSesion(Menu menu)
        {
            bool emailExiste, usuarioLogueado, contraCorrecta;
            int e = 0;
            do
            {
                emailExiste = true;
                usuarioLogueado = false;

                Console.Write("Ingrese su email: ");
                isEmail = Console.ReadLine();

                foreach (Socio item in ListaDeSocios)
                {
                    if (isEmail == item.Email)
                    {
                        int c = 0;
                        do
                        {
                            contraCorrecta = true;

                            Console.Write("Ingrese su contraseña: ");
                            string isContraseña = Console.ReadLine();

                            if (isContraseña == item.Contraseña)
                            {
                                Console.WriteLine("Usuario logueado correctamente.\n");
                                usuarioLogueado = true;
                            }
                            else
                            {
                                Console.WriteLine("\nContraseña incorrecta.\n");
                                contraCorrecta = false;
                                c++;
                                /*
                                if (c > 2)
                                {
                                    menu.IniciarPrograma(); // COMO LLAMAR
                                }
                                */
                            }
                        } while (contraCorrecta == false);
                    }
                    else
                    {
                        emailExiste = false;
                        e++;
                        /*
                        if (e > 2)
                        {
                            menu.IniciarPrograma(); // COMO LLAMAR
                        }
                        */
                    }
                }
            } while (emailExiste == false);


            bool volver = false;
            do
            {
                Console.WriteLine("1 -> Actualizar los Datos.");
                Console.WriteLine("2 -> Para Ver Información");
                Console.WriteLine("0 -> Para Volver al Menu.");
                int p;
                do
                {
                    Console.Write("Elija una opcion: ");
                    p = Convert.ToInt32(Console.ReadLine());
                } while (p != 1 && p != 2 && p != 0);

                switch (p)
                {
                    case 0:
                        volver = false;
                        break;

                    case 1:
                        ActualizarDatos(isEmail);
                        menu.KeyToReturn();
                        volver = true;
                        break;

                    case 2:
                        VerInformacion(isEmail);
                        menu.KeyToReturn();
                        volver = true;
                        break;
                }

            } while (volver == true);
        }

        //ACTUALIZAR INFORMACION
        public void ActualizarDatos(string isEmail)
        {

            Console.WriteLine("1 -> Actualizar Datos Personales.");
            Console.WriteLine("2 -> Actualizar Estado de Salud.");
            Console.WriteLine("3 -> Actualizar Creedenciales de Inicio.");
            int o;
            do
            {
                Console.Write("Elija una opcion: ");
                o = Convert.ToInt32(Console.ReadLine());
            } while (o != 1 && o != 2 && o != 3);

            switch (o)
            {
                case 1:
                    Console.WriteLine("1 -> Cambiar Nombre.");
                    Console.WriteLine("2 -> Cambiar Apellido.");
                    Console.WriteLine("3 -> Cambiar DNI.");
                    Console.WriteLine("4 -> Cambiar Fecha de Nacimiento.");
                    Console.WriteLine("5 -> Cambiar Domicilio.");
                    Console.WriteLine("6 -> Cambiar Localidad.");
                    Console.WriteLine("7 -> Cambiar Telefono.");
                    int u;
                    do
                    {
                        Console.Write("Elija una opcion: ");
                        u = Convert.ToInt32(Console.ReadLine());
                    } while (u != 1 && u != 2 && u != 3 && u != 4 && u != 5 && u != 6 && u != 7);

                    switch (u)
                    {
                        case 1:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese el nuevo nombre: ");
                                    item.Nombre = Console.ReadLine();
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;

                        case 2:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese el nuevo apellido: ");
                                    item.Apellido = Console.ReadLine();
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;

                        case 3:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese el nuevo DNI: ");
                                    item.Dni = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;

                        case 4:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese la nueva fecha de nacimiento: ");
                                    item.FechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());
                                    item.Categoria = item.CalcularCategoria();
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;

                        case 5:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese el nuevo domicilio: ");
                                    item.Domicilio = Console.ReadLine();
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;

                        case 6:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese la nueva localidad: ");
                                    item.Localidad = Console.ReadLine();
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;

                        case 7:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese el nuevo numero de telefono: ");
                                    item.Telefono = Console.ReadLine();
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;
                    }
                    break;

                case 2:
                    foreach (var item in listaDeSocios)
                    {
                        if (isEmail == item.Email)
                        {
                            Console.Write("Ingrese nuevamente si posee una enfermedad (true o false): ");
                            item.Enfermedad = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("\nCambios guardados exitosamente.\n");

                            if (item.Enfermedad == true)
                            {
                                item.Categoria = "pasivo";
                                Console.Write("Ingrese nuevamente si toma medicacion (true o false): ");
                                item.TomaMedicacion = Convert.ToBoolean(Console.ReadLine());
                                Console.WriteLine("\nCambios guardados exitosamente.\n");

                                if (item.TomaMedicacion == true)
                                {
                                    Console.Write("Ingrese el nuevo medicamento que toma: ");
                                    item.Medicamento = Console.ReadLine();
                                    Console.WriteLine("\nCambios guardados exitosamente.\n");
                                }
                                else
                                {
                                    item.Medicamento = "no consume ninguna medicacion";
                                }
                            }
                            else
                            {
                                item.Categoria = item.CalcularCategoria();
                                item.TomaMedicacion = false;
                                item.Medicamento = "no consume ninguna medicacion";
                                Console.WriteLine("\nCambios guardados exitosamente.\n");
                            }
                        }
                    }
                    break;


                case 3:
                    Console.WriteLine("1 -> Cambiar email.");
                    Console.WriteLine("2 -> Cambiar contraseña.");
                    int e;
                    do
                    {
                        Console.Write("Elija una opcion: ");
                        e = Convert.ToInt32(Console.ReadLine());
                    } while (e != 1 && e != 2);

                    switch (e)
                    {
                        case 1:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese el nuevo email: ");
                                    item.Email = Console.ReadLine();
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;

                        case 2:
                            foreach (var item in listaDeSocios)
                            {
                                if (isEmail == item.Email)
                                {
                                    Console.Write("Ingrese la nueva contraseña: ");
                                    item.Contraseña = Console.ReadLine();
                                }
                            }
                            Console.WriteLine("\nCambios guardados exitosamente.\n");
                            break;
                    }
                    break;
            }
        }

        //REGISTRARSE
        public void RegistrarDatosDeLaPersona(ValidarSocio vs)
        {
            Console.Write("Ingrese su grupo sanguineo (letra en mayúscula y simbolo + o -) : ");
            grupoSanguineo = Console.ReadLine();
            grupoSanguineo = vs.ValidarGrupoSanguineo(grupoSanguineo);

            if (grupoSanguineo == "A+" || grupoSanguineo == "B+" || grupoSanguineo == "AB+" || grupoSanguineo == "0+")
            {
                Console.WriteLine("\nUsted no puede ingresar al circulo. Solo se permite sangre RH Negativo");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nUsted es aceptado en el circulo. Complete el resto de los datos.\n");
            }

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            nombre = vs.ValidarNombre(nombre);

            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            apellido = vs.ValidarApellido(apellido);

            Console.Write("Ingrese su DNI sin puntos: ");
            string stringdni = Console.ReadLine();
            dni = vs.ValidarDni(stringdni);

            Console.Write("Ingrese su fecha de nacimiento con el formato **/**/**** : ");
            string stringfechaDeNacimiento = Console.ReadLine();
            fechaDeNacimiento = vs.ValidarFechaDeNacimiento(stringfechaDeNacimiento);

            Console.Write("Ingrese su domicilio: ");
            domicilio = Console.ReadLine();
            domicilio = vs.ValidarDomicilio(domicilio);

            Console.Write("Ingrese su localidad: ");
            localidad = Console.ReadLine();
            localidad = vs.ValidarLocalidad(localidad);

            Console.Write("Ingrese su telefono con el formato ****-******: ");
            telefono = Console.ReadLine();
            telefono = vs.ValidarTelefono(telefono);

            Console.Write("Posee alguna enfermedad cronica (true o false): ");
            string stringenfermedad = Console.ReadLine();
            enfermedad = vs.ValidarEnfermedad(stringenfermedad);

            if (enfermedad == true)
            {
                Console.Write("Toma alguna medicacion (true o false): ");
                string stringtomaMedicacion = Console.ReadLine();
                tomaMedicacion = vs.ValidarTomaMedicacion(stringtomaMedicacion);

                if (tomaMedicacion == true)
                {
                    Console.Write("Ingrese que medicacion consume: ");
                    medicamento = Console.ReadLine();
                    medicamento = vs.ValidarMedicamento(medicamento);
                }
                else
                {
                    medicamento = "no consume ninguna medicacion";
                }
            }
            else
            {
                tomaMedicacion = false;
                medicamento = "no consume ninguna medicacion";
            }

            Console.Clear();

            MostrarReglamento();

            Console.Write("\nEsta de acuerdo con las condiciones (true o false): ");
            string stringresp = Console.ReadLine();
            bool resp = vs.ValidarAceptarCondiciones(stringresp);

            Console.Clear();

            if (resp == true)
            {
                Console.WriteLine("CREDENCIALES DE INICIO DE SESION\n");

                Console.Write("Ingrese su email: ");
                email = Console.ReadLine();
                email = vs.ValidarEmail(email);

                Console.Write("\nIngrese una contraseña: ");
                contraseña = Console.ReadLine();
                contraseña = vs.ValidarContraseña(contraseña);

                CalcularCategoria();
                CargarListado();
            }
            else
            {
                Console.WriteLine("No puede entrar al circulo.");
                Environment.Exit(0);
            }
        }

        //MUESTRA EL REGLAMENTO DEL CIRCULO DE SANGRE
        public void MostrarReglamento()
        {
            Console.WriteLine("\n- - - - - - - - - - - - - - - REGLAMENTO DEL CIRCULO DE SANGRE - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("El circulo de sangre RH Negativo reúne a todas las personas que posean el factor RH " +
            "Negativo, sea cual fuera su grupo sanguíneo, logrando de esta manera un sistema de autoprotección " +
            "mediante el cual los asociados, podrán donarse sangre entre si para el momento en que así lo " +
            "necesiten. \nExisten dos categorías de socios, activos y pasivos, los activos son quienes están " +
            "en condiciones de donar sangre y se determina por la edad (entre 18 y 56 años); los pasivos son " +
            "los menores a 18 años y mayores a 56 años. Además, se considera pasivos a quienes posean una enfermedad " +
            "crónica y deban tomar medicamentos de forma permanente. \nPara poder pertencer al Circulo las personas " +
            "se deben asociar y pagar una cuota de manera mensual." +
            "\nCuota Socio Activo: $8500" + "\nCuota Socio Pasivo: $12300");
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
        }

        //SE CARGAN LOS DATOS EN LA LISTA SI LA PERSONA ACEPTA EL REGLAMENTO
        public void CargarListado()
        {
            ListaDeSocios.Add(new Socio()
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                GrupoSanguineo = grupoSanguineo,
                FechaDeNacimiento = fechaDeNacimiento,
                Domicilio = domicilio,
                Localidad = localidad,
                Telefono = telefono,
                Enfermedad = enfermedad,
                TomaMedicacion = tomaMedicacion,
                Medicamento = medicamento,
                Email = email,
                Contraseña = contraseña,
                Categoria = CalcularCategoria(),
                FechaDeUltimaDonacion = new DateTime(2000, 01, 01),
                CantDeDonaciones = 0,
                Condicion = CalcularCondicion()
            });
        }

        //MUESTRA TODOS LOS DATOS DE LOS SOCIOS (DE PREUBA)
        public void MostrarListado()
        {
            foreach (var item in ListaDeSocios)
            {
                item.DatosDelSocio();
            }
        }

        //PASIVO O ACTIVO
        public string CalcularCategoria()
        {
            int edad = DateTime.Today.AddTicks(-FechaDeNacimiento.Ticks).Year - 1;
            if (edad >= 18 && edad <= 56 && Enfermedad == false)
            {
                Categoria = "activo";
            }
            else
            {
                Categoria = "pasivo";
            }
            return Categoria;
        }

        //DATOS DEL SOCIO
        public void DatosDelSocio()
        {
            Console.WriteLine("\nNombre y apellido: " + Nombre + " " + Apellido);
            Console.WriteLine("DNI: " + Dni);
            Console.WriteLine("Grupo Sanguineo: " + GrupoSanguineo);
            Console.WriteLine("Fecha de nacimiento: " + FechaDeNacimiento.ToShortDateString());
            Console.WriteLine("Domicilio y localidad: " + Domicilio + ", " + Localidad);
            Console.WriteLine("Telefono: " + Telefono);
            Console.WriteLine("Enfermedad, toma medicacion y medicamento: " + Enfermedad + ", " + TomaMedicacion + ", " + Medicamento);
            Console.WriteLine("Email y contraseña: " + Email + ", " + Contraseña);
            Console.WriteLine("Categoria: " + Categoria);
            Console.WriteLine("Fecha de ultima donacion: " + FechaDeUltimaDonacion);
            Console.WriteLine("Cantidad de donaciones en el año: " + CantDeDonaciones);
            Console.WriteLine("Condicion: " + Condicion);
        }

        //VER INFORMACION DEL SOCIO
        public void VerInformacion(string isEmail)
        {
            foreach (var item in ListaDeSocios)
            {
                if (isEmail == item.Email)
                {
                    item.DatosDelSocio();
                }
            }
        }

        //CALCULAR CONDICION (disponible --> socio activo, mas de 4 desde la ultima donacion, menos de dos donaciones en el año)
        public string CalcularCondicion()
        {
            int plazo;
            if (FechaDeUltimaDonacion == new DateTime(2000, 1, 1))
            {
                plazo = 4;
            }
            else
            {
                plazo = DateTime.Today.AddTicks(-FechaDeUltimaDonacion.Ticks).Month - 1;
            }

            if (Categoria == "activo" && plazo >= 4 && CantDeDonaciones < 2)
            {
                Condicion = "disponible";
            }
            else
            {
                Condicion = "nodisponible";
            }
            return Condicion;
        }
    }
}
