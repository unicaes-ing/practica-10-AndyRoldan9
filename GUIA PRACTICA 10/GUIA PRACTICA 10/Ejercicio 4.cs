using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GUIA_PRACTICA_10
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            string usuario, contraseñaAcceso, test;
            int intentos = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("ESCRIBE LOS PARAMETROS QUE SE PIDEN PARA INICIAR SESION: ");
                Console.WriteLine();
                Console.Write("NOMBRE DE USUARIO: ");
                usuario = Console.ReadLine();
                Console.Write("CONTRASEÑA DE ACCESO: ");
                contraseñaAcceso = Console.ReadLine();
                test = usuario + ":" + contraseñaAcceso;
                if (testear(test) == true)
                {
                    Console.WriteLine("ACCEDIENDO AL SISTEMA...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("ERROR 404...");
                    Console.ReadKey();
                    intentos++;
                }
            } while (intentos != 3);
            if (intentos == 3)
            {
                Console.WriteLine("MAS DE 3 INTENTOS...");
                Console.WriteLine("SE HA BLOQUEADO EL SISTEMA");
                Console.ReadLine();
            }
        }
        static bool testear(string contraseñaAcceso)
        {
            string buscar;
            bool verdad = false;
            StreamReader Buscar = new StreamReader(@"c:\archivos\RegistoUsuario.txt");
            do
            {
                buscar = Buscar.ReadLine();
                if (buscar == contraseñaAcceso)
                {
                    verdad = true;
                }
            } while (buscar != null);
            return verdad;
        }
    }
    
}
