
//Práctica 2 para examen: En este menú escoge de las seis opciones la que mas deseas
//Estudiante: José Pablo Muñoz Zúñiga
//Carrera: Ingeniería Informática
//Materia: Programación II

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta es la práctica para examen 2 
namespace Práctica_2_para_examen_programación_II
{
    //El programa trata de un menu de opciones del flujo vehicular
    class Programa_vehicular
    {
        //En esta parte tienes demasiados codigos los cuales es para que el programa funcione
        public struct vehicular
        {
            //En esta parte son los codigos los cuales se ejecutaran más adelante en el menu

            public String factura_vehicular;
            public String placa_vehicular;
            public String fecha_vehicular;
            public String hora_vehicular;
            public String tipo_vehiculo;
            public String numero_caseta;
            public String monto_pagar;
            public String pagar_con;
            public String vuelto;
            public String estado;

        }

        //En esta parte es un codigo que se ejecutara más adelante donde el usuario elige el tipo de vehiculo que desea
        enum Tipovehiculo { Moto, VehiculoLiviano, CamionoPesado, Autobus }
        //En esta parte es un codigo que se ejecutara más adelante donde el usuario elige el numero de caseta que desee
        enum Numerocaseta { Casetauno, Casetados, Casetatres }
        //En esta parte es un codigo que se ejecutara más adelante donde el usuario puede elegir el monto a pagar que desee
        enum Montopagar { Quinientos, Setecientos }
        //En esta parte es un codigo que se ejecutara más adelante donde el usuario puede elegir el paga con que desee
        enum Pagacon { Dosmil, Mil }
        //En esta parte es un codigo que se ejecutara más adelante donde el usuario puede elegir el vuelto que desee
        enum Vuelto { Milquinientos, Tresmil }
        //En esta parte es un codigo que se ejecutara más adelante donde el usuario puede elegir el estado cuenta que desee
        enum Estadoflujovehicular { activo, ninguno, inactivo }

        const int tope = 5;
        static vehicular[] lista = new vehicular[tope];
        static int contador = 0;

        //En esta parte es el punto de entrada para que todo el programa funcione
        static void Main(string[] args)
        {
            menu();
        }

        //En esta parte hay un menu donde el usuario ingresa la opcion que desee
        public static void menu()
        {
            //En esta parte puedes elegir cual opcion deseas

            int opcion;

            Console.WriteLine("---Menu-de-opciones---");
            Console.WriteLine("1.-Inicializar Vectores");
            Console.WriteLine("2.-Ingrese Datos del Cliente");
            Console.WriteLine("3.-Consultar");
            Console.WriteLine("4.-Modificar");
            Console.WriteLine("5.-Reporte de todos de los vectos");
            Console.WriteLine("6.-Salir");
            do
            {
                //En esta parte usted ingresa una opcion que deseas

                Console.WriteLine("Ingrese la Opcion :");
                opcion = int.Parse(Console.ReadLine());
                if (opcion <= 0 || opcion >= 2)
                {
                    //En esta parte se ingreso una opcion valida

                    Console.WriteLine("Ingrese una opcion validad");
                }
            } while (opcion > 6);
            switch (opcion)
            {
                //En esta parte es la programacion del menu de opciones que el usuario ingresa 
                case 1: inicializarvectores(); break;
                case 2: ingresardatos(); break;
                case 3: consultardatos(); break;
                case 4: modificardatos(); break;
                case 5: reportetodoslosdatosdelosvectores(); break;

            }
        }

        //En esta parte usted selecciono inicializar vectores
        public static void inicializarvectores()
        {
            //En esta parte datos del flujo vehicular quedan registrados en los vectores
            string[] uni = new string[12];
            uni[0] = "                            Titulo del Reporte                              ";
            uni[1] = "N factura  Placa  Tipo de vehículo      Caseta   monto Pagar paga con vuelto";
            uni[2] = "----------------------------------------------------------------------------";
            uni[3] = "----------------------------------------------------------------------------";
            uni[4] = "1          111111         1               2      500         2000     1500  ";
            uni[5] = "2          222222         2               3      700         1000     300   ";
            uni[6] = "----------------------------------------------------------------------------";
            uni[7] = "----------------------------------------------------------------------------";
            uni[8] = "Cantidad de vehículos: 2                  total: 1200                       ";
            uni[9] = "----------------------------------------------------------------------------";
            uni[10] = "---------------------------------------------------------------------------";
            uni[11] = "                      <<<Pulse tecla para regresar>>>                      ";

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("{1}", i, uni[i]);
            }

            Console.ReadKey();

            menu();
        }

        //En esta parte usted selecciono ingresar datos
        public static void ingresardatos()
        {
            //lista = new cliente[tope];
            for (int i = contador; i < tope; i++)
            {
                //En esta parte vas a ingresar los datos del flujo vehicular
                Console.WriteLine("Ingrese de datos del flujo vehicular " + (i + 1));

                //En esta parte ingrese el numero de factura vehicular
                Console.WriteLine("Ingrese el numero de factura vehicular: ");
                lista[i].factura_vehicular = Console.ReadLine();

                //En esta parte ingrese el numero de placa vehicular
                Console.WriteLine("Ingrese el numero de placa vehicular: ");
                lista[i].placa_vehicular = Console.ReadLine();

                //En esta parte ingrese la fecha vehicular
                Console.WriteLine("Ingrese la fecha vehicular: ");
                lista[i].fecha_vehicular = Console.ReadLine();

                //En esta parte ingrese la hora vehicular
                Console.WriteLine("Ingrese la hora vehicular: ");
                lista[i].hora_vehicular = Console.ReadLine();

                //En esta parte ingrese el tipo de vehiculo
                Console.WriteLine("Ingrese el tipo de vehiculo: ");
                lista[i].tipo_vehiculo = seleccionartipodevehiculo();

                //En esta parte ingrese el numero de caseta del vehiculo
                Console.WriteLine("Ingrese el numero de caseta del vehiculo");
                lista[i].numero_caseta = seleccionarnumerocaseta();

                //En esta parte ingrese el monto a pagar
                Console.WriteLine("Ingrese el monto a pagar: ");
                lista[i].monto_pagar = seleccionarmontopagar();

                //En esta parte ingrese la paga con
                Console.WriteLine("Cuanto la paga con: ");
                lista[i].pagar_con = seleccionarpagacon();

                //En esta parte ingrese el vuelto
                Console.WriteLine("Cuanto es el vuelto: ");
                lista[i].vuelto = seleccionarvuelto();
                contador++;

                //En esta parte ingrese el estado de flujo vehicular

                //Console.WriteLine("Estado de flujo vehicular: ");
                lista[i].estado = Estadoflujovehicular.activo.ToString();

                //En esta parte se ingresa el valor maxico para ingresar alcanzado

                if (contador > tope)
                {
                    Console.WriteLine("Valor maximo para ingresar alcanzado");
                    break;
                }
            }

            menu();
        }

        //En esta parte usted selecciono consultar datos
        public static void consultardatos()
        {
            //En esta parte puedes ver todos los digitados con anterioridad
            for (int i = 0; i < tope; i++)
            {
                if (lista[i].estado.Equals("activo") || lista[i].estado.Equals("inactivo"))
                {
                    Console.WriteLine("Consulta del flujo vehicular");
                    Console.WriteLine("Factura vehicular           : " + lista[i].factura_vehicular);
                    Console.WriteLine("Placa vehicular             : " + lista[i].placa_vehicular);
                    Console.WriteLine("Fecha vehicular             : " + lista[i].fecha_vehicular);
                    Console.WriteLine("Hora vehicular              : " + lista[i].hora_vehicular);
                    Console.WriteLine("Tipo de vehiculo            : " + lista[i].tipo_vehiculo);
                    Console.WriteLine("Numero de caseta            : " + lista[i].numero_caseta);
                    Console.WriteLine("Monto a pagar               : " + lista[i].monto_pagar);
                    Console.WriteLine("Pagar con                   : " + lista[i].pagar_con);
                    Console.WriteLine("Vuelto                      : " + lista[i].vuelto);
                }
                //En esta parte el usuario ingreso unos datos que no existen
                else
                {
                    Console.WriteLine("No hay datos");
                }

            }
            menu();

        }

        //En esta parte usted selecciono modificar datos
        public static void modificardatos()
        {
            //En esta parte son los condigos para que el programa de modificar datos funcione
            string respuesta = "";
            string nvfacturavehicular, nvplacavehicular, nvfechavehicular, nvhoravehicular, nvtipovehiculo, nvnumerocaseta, nvmontopagar, nvpagacon, nvvuelto;
            int nuevodato = 0;
            do
            {
                //En esta parte usted elegir si modificar los datos del cliente
                Console.WriteLine("Desea Modificar los datos del flujo vehicular");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();

                //En esta parte al escoger la opcion si modificar los datos del cliente, usted puedes modificar los datos del cliente

                if (respuesta.Equals("SI"))
                {
                    if (nuevodato >= 0 && nuevodato < lista.Length)

                    {
                        //En esta parte ingrese el nuevo numero de factura vehicular
                        Console.WriteLine("Ingrese el nuevo numero de factura :" + lista[nuevodato].factura_vehicular);
                        nvfacturavehicular = Console.ReadLine();
                        lista[nuevodato].factura_vehicular = nvfacturavehicular;

                        //En esta parte ingrese el nuevo numero de placa vehicular
                        Console.WriteLine("Ingrese el nuevo numero de placa :" + lista[nuevodato].placa_vehicular);
                        nvplacavehicular = Console.ReadLine();
                        lista[nuevodato].factura_vehicular = nvplacavehicular;

                        //En esta parte ingrese la nueva fecha vehicular
                        Console.WriteLine("Ingrese la nueva fecha vehicular :" + lista[nuevodato].fecha_vehicular);
                        nvfechavehicular = Console.ReadLine();
                        lista[nuevodato].fecha_vehicular = nvfechavehicular;

                        //En esta parte ingrese la nueva hora vehicular
                        Console.WriteLine("Ingrese hora vehicular :" + lista[nuevodato].hora_vehicular);
                        nvhoravehicular = Console.ReadLine();
                        lista[nuevodato].hora_vehicular = nvhoravehicular;

                        //En esta parte ingrese el tipo de vehiculo
                        Console.WriteLine("Ingrese el tipo de vehiculo : " + lista[nuevodato].tipo_vehiculo);
                        nvtipovehiculo = seleccionartipodevehiculo();
                        lista[nuevodato].tipo_vehiculo = nvtipovehiculo;

                        //En esta parte ingrese el numero de caseta
                        Console.WriteLine("Ingrese el numero de caseta :" + lista[nuevodato].numero_caseta);
                        nvnumerocaseta = seleccionarnumerocaseta();
                        lista[nuevodato].numero_caseta = nvnumerocaseta;

                        //En esta parte ingrese el monto a pagar
                        Console.WriteLine("Ingrese el monto a pagar :" + lista[nuevodato].monto_pagar);
                        nvmontopagar = seleccionarmontopagar();
                        lista[nuevodato].monto_pagar = nvmontopagar;

                        //En esta parte ingrese el paga con
                        Console.WriteLine("Ingrese el paga con :" + lista[nuevodato].pagar_con);
                        nvpagacon = seleccionarpagacon();
                        lista[nuevodato].pagar_con = nvpagacon;

                        //En esta parte ingrese el vuelto
                        Console.WriteLine("Ingrese el vuelto :" + lista[nuevodato].vuelto);
                        nvvuelto = seleccionarvuelto();
                        lista[nuevodato].vuelto = nvvuelto;

                    }

                    //En esta parte usted puede escoger en no modificiar los datos del cliente

                    else if (respuesta.Equals("NO"))
                    {
                        Console.WriteLine("Gracias por su Atencion ");
                    }


                }
                //En esta parte usted puede escoger si modificar los datos del cliente
            } while (respuesta.Equals("SI"));

            menu();

            Console.ReadLine();
        }

        //En esta parte usted selecciono seleccionar pagar con
        public static string seleccionarpagacon()
        {
            int opcion = 0;
            string Pagarcon = "";

            //En esta parte usted selecciona la opcion de paga con que deseas
            Console.WriteLine("Seleccione : 1. - Dosmil 2.-Mil");
            opcion = int.Parse(Console.ReadLine());

            //En esta parte usted selecciono el pagar con Dosmil
            if (opcion == 1)
            {
                Pagarcon = Pagacon.Dosmil.ToString();
            }

            //En esta parte usted selecciono el pagar con Mil
            else if (opcion == 2)
            {
                Pagarcon = Pagacon.Mil.ToString();
            }
            return Pagarcon;
        }

        //En esta parte usted selecciono seleccionar numero caseta
        public static string seleccionarnumerocaseta()
        {
            int opcion = 0;
            string estadoc = "";

            //En esta parte usted selecciona la opcion el numero de caseta que deseas
            Console.WriteLine("Seleccionar: 1.-Caseta 1 2.-Caseta 2 3.-Caseta 3 ");
            opcion = int.Parse(Console.ReadLine());

            //En esta parte usted usted selecionaste el numero de caseta que usted deseo
            switch (opcion)
            {
                //En esta parte usted selecciono el numero de caseta uno
                case 1: estadoc = Numerocaseta.Casetauno.ToString(); break;
                //En esta parte usted selecciono el numero de caseta dos
                case 2: estadoc = Numerocaseta.Casetados.ToString(); break;
                //En esta parte usted selecciono el numero de caseta tres
                case 3: estadoc = Numerocaseta.Casetatres.ToString(); break;
            }
            return estadoc;
        }

        //En esta parte usted selecciono seleccionar tipo de vehiculo
        public static string seleccionartipodevehiculo()
        {
            int opcion = 0;
            string acc = "";

            //En esta parte usted selecciona la opcion de tipo de vehiculo que deseas
            Console.WriteLine("Seleccione el tipo de vehiculo: 1.-Moto  2.-VehiculoLiviano 3.-CamionoPesado 4.-Autobus");
            opcion = int.Parse(Console.ReadLine());

            //En esta parte usted escogio el tipo de vehiculo el cual fue una moto
            if (opcion == 1)
            {
                acc = Tipovehiculo.Moto.ToString();
            }

            //En esta parte usted escogio el tipo de vehiculo el cual fue un vehiculo liviano
            else if (opcion == 2)
            {
                acc = Tipovehiculo.VehiculoLiviano.ToString();
            }

            //En esta parte usted escogio el tipo de vehiculo el cual fue un camion o pesado
            else if (opcion == 3)
            {
                acc = Tipovehiculo.CamionoPesado.ToString();
            }

            //En esta parte usted escogio el tipo de vehiculo el cual fue un autobus
            else if (opcion == 4)
            {
                acc = Tipovehiculo.Autobus.ToString();
            }

            return acc;
        }

        //En esta parte usted secciono seleccionar monto pagar
        public static string seleccionarmontopagar()
        {
            int opcion = 0;
            string acc2 = "";

            //En esta parte usted selecciona la opcion de monto pagar deseas
            Console.WriteLine("Seleccione el monto pagar: 1.-Quinientos 2.-Setecientos");
            opcion = int.Parse(Console.ReadLine());

            //En esta parte usted escogio el monto pagar de quinientos
            if (opcion == 1)
            {
                acc2 = Montopagar.Quinientos.ToString();
            }
            //En esta parte usted escogio el monto pagar de setecientos
            else if (opcion == 2)
            {
                acc2 = Montopagar.Setecientos.ToString();
            }

            return acc2;
        }

        //En esta parte usted secciono seleccionarvuelto
        public static string seleccionarvuelto()
        {
            int opcion = 0;
            string ess2 = "";

            //En esta parte usted selecciona la opcion de vuelto que deseas 
            Console.WriteLine("Seleccione el vuelto: 1.-Milquinientos 2.-Tresmil");
            opcion = int.Parse(Console.ReadLine());

            //En esta parte usted escogio el vuelto de milquinientos
            if (opcion == 1)
            {
                ess2 = Vuelto.Milquinientos.ToString();
            }
            //En esta parte usted escogio el vuelto de tresmil
            else if (opcion == 2)
            {
                ess2 = Vuelto.Tresmil.ToString();
            }

            return ess2;

        }

        //En esta parte usted selecciono seleccionar estado
        public static string seleccionarestado()
        {
            int opcion = 0;
            string ess = "";

            //En esta usted parte selecciona la opcion de estado de consultas que deseas
            Console.WriteLine("Seleccione una opcion: 1.-activo 2.-eliminado 3.-inactivo");
            opcion = int.Parse(Console.ReadLine());

            //En esta parte se escogio el estado activo de las consultas del flujo vehicular
            if (opcion == 1)
            {
                ess = Estadoflujovehicular.activo.ToString();
            }

            //En esta parte se escogio el estado eliminado de las consultas del flujo vehicular
            else if (opcion == 2)
            {
                ess = Estadoflujovehicular.ninguno.ToString();
            }

            //En esta parte se escogio el estado inactivo de las consultas del flujo vehicular
            else if (opcion == 3)
            {
                ess = Estadoflujovehicular.inactivo.ToString();
            }

            return ess;
        }

        //En esta parte se hace el reporte todos los datos de los vectores del flujo vehicular
        public static void reportetodoslosdatosdelosvectores()
        {
            //En esta se muestra el reporte de todos los datos de los vectores del flujo vehicular

            Console.WriteLine("                          Titulo del Reporte                              ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("N factura placa tipo de vehículo caseta monto Pagar pagar con vuelto      ");
            Console.WriteLine("1         111111         1             2   500          2000    1500      ");
            Console.WriteLine("2         222222         2             3   700          1000     300      ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Cantidad de vehículos: 2                      total: 1200                 ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("                          <<<Pulse tecla para regresar>>>                 ");

            menu();
        }

    }



}
