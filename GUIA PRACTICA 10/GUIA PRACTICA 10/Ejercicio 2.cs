using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using GUIA_PRACTICA_10;

namespace GUIA_PRACTICA_10
{
    class Ejercicio_2
    {
        public static void MenuInicial()
        //NOMBRE: ANDY WILLIAM GUEVARA ROLDAN.
        // FECHA DE CREACION: JUEVES 24 DE OCTUBRE DE 2019.
        {

            int opc;
            Console.SetCursorPosition(70, 10);
            Console.WriteLine("-------QUE DESEAS HACER-------");
            Console.SetCursorPosition(65, 12);
            Console.WriteLine("[1]---------------AGREGAR UN PAIS");
            Console.SetCursorPosition(65, 14);
            Console.WriteLine("[2]---------------MOSTRAR LA LISTA DE PAISES");
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("[3]---------------BUSCAR UN PAIS EN ESPECIFICO");
            Console.SetCursorPosition(65, 18);
            Console.WriteLine("[4]---------------SALIR DE EL PROGRAMA");
            Console.SetCursorPosition(65, 21);
            Console.Write("ESCRIBE ALGUNA OPCION:  ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Agregar();
                    break;
                case 2:
                    Console.Clear();
                    Mostrar();
                    break;
                case 3:
                    Console.Clear();
                    Buscar();

                    break;
            }
        }
        static void Main(string[] args)
        {
            //NOMBRE: ANDY WILLIAM GUEVARA ROLDAN.
            // FECHA DE CREACION: JUEVES 24 DE OCTUBRE DE 2019.
            MenuInicial();
            Console.ReadKey();
        }

        public static void Agregar()
        {
            //NOMBRE: ANDY WILLIAM GUEVARA ROLDAN.
            // FECHA DE CREACION: JUEVES 24 DE OCTUBRE DE 2019.  
            try
            {
                StreamWriter pais = new StreamWriter(@"c:\archivos\paises.txt", true);
                Console.WriteLine();
                string[] add;
                string Pais;
                int cantPaises;
                Console.Write("\n¿Cual es la cantidad de paises que desea agregar?: ");
                cantPaises = Convert.ToInt32(Console.ReadLine());
                add = new string[cantPaises];
                for (int i = 1; i <= cantPaises; i++)
                {
                    Console.Write("Ingresa el pais: ");
                    Pais = Console.ReadLine();
                    if (Pais == "")
                    {
                        Console.WriteLine("Dato invalido");
                        i--;
                    }
                    else
                    {
                        pais.WriteLine(Pais);
                    }
                }
                pais.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("<error> no se ha podido guardar");
            }
            Console.ReadKey();
                Console.Clear();
                MenuInicial();
        }

          


        

        public static void Mostrar()
        {
            //NOMBRE: ANDY WILLIAM GUEVARA ROLDAN.
            // FECHA DE CREACION: JUEVES 24 DE OCTUBRE DE 2019.
            StreamReader pais = new StreamReader(@"c:\archivos\paises.txt");
            string mostrar;
            mostrar = pais.ReadToEnd();
            Console.WriteLine("ESTA ES LA LISTA DE PAISES QUE HAS GUARDADO");
            Console.WriteLine();
            Console.WriteLine(mostrar);
            pais.Close();
            Console.ReadKey();
            Console.Clear();
            MenuInicial();
        }

        public static void Buscar()
        {

            string paisRegistrado, buscarPais;
            bool paisEncontrado = false;
            Console.Clear();
            StreamReader buscar = new StreamReader(@"c:\archivos\paises.txt");
            Console.Write("INGRESA EL PAIS QUE DESEAS BUSCAR: ");
            buscarPais = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                paisRegistrado = buscar.ReadLine();
                if (buscarPais.Equals(paisRegistrado))
                {
                    Console.Write("\nPAIS ENCONTRADO CON EXITO");
                    Console.ReadLine();
                    paisEncontrado = true;
                    break;
                }
            } while (paisRegistrado != null);
            if (paisEncontrado == false)
            {
                Console.WriteLine("\n\nNO SE PUDO ENCONTRAR EL PAIS : ");
                Console.Write("SI LO DESEAS PUEDES AGREGARLO A LA LISTA");
                Console.ReadLine();
            }
            buscar.Close();
            Console.Clear();
            MenuInicial();
        }
    }
}
