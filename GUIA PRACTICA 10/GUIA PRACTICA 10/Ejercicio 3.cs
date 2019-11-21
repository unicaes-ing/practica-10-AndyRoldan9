using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_PRACTICA_10
{
    class Ejercicio_3
    {
        //NOMBRE: ANDY WILLIAM GUEVARA ROLDAN.
        // FECHA DE CREACION: JUEVES 24 DE OCTUBRE DE 2019.
        public static void MenuInicial()
        {
            
            int opcMenu;
            Console.SetCursorPosition(70, 10);
            Console.WriteLine("-------BIENVENIDO A SU ALMACENES SIMAN-------");
            Console.SetCursorPosition(65, 12);
            Console.WriteLine("[1]---------------REGISTRARSE EN EL SISTEMA");
            Console.SetCursorPosition(65, 14);
            Console.WriteLine("[2]---------------SALIR DEL PROGRAMA");
            Console.SetCursorPosition(65, 16);
            Console.Write("ESCRIBE ALGUNA OPCION:  ");
            opcMenu = Convert.ToInt32(Console.ReadLine());

            switch (opcMenu)
            {
                case 1:
                    Console.Clear();
                    ingresarSistema();
                    break;
                case 2:
                    Environment.Exit(1);
                    break;
            }
        }
            public static void ingresarSistema()
            {
            StreamWriter acceso = new StreamWriter(@"c:\archivos\RegistoUsuario.txt", true);
            bool usuario = false;
            bool contraseña = false;
            bool exam = false;
            string nombreUsuario, ContraseñaAcceso, testear;
            do
            {
                Console.Clear();
                Console.Write("NOMBRE DE USUARIO: ");
                nombreUsuario = Console.ReadLine();
                if (nombreUsuario == "")
                {
                    Console.WriteLine("NO SE PUESDE DEJAR EN BLANCO");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("HAS ENTRADO AL SISTEMA");
                    Console.ReadKey();
                    usuario = true;
                }
            } while (usuario == false);
            do
            {
                Console.Clear();
                Console.WriteLine("NOMBRE DE USUARIO: {0}", nombreUsuario);
                Console.Write("CONTRASEÑA: ");
                ContraseñaAcceso = Console.ReadLine();
                if (ContraseñaAcceso.Length < 7 || ContraseñaAcceso.Length > 20)
                {
                    Console.Write("\nLA CONTRASEÑA DE ACCESO DEBE CONTENER DE 7 A 20 CARACTERES");
                    Console.ReadKey();
                }
                else
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("NOMBRE DE USUARIO {0}", nombreUsuario);
                        Console.Write("\nVUELVE A ESCRIBIR LA CONTRASEÑA: ");
                        testear = Console.ReadLine();
                        if (testear.Equals(ContraseñaAcceso))
                        {
                            Console.WriteLine("CONTRASEÑA VALIDA");
                            Console.ReadKey();
                            exam = true;
                            contraseña = true;
                        }
                        else
                        {
                            Console.Write("\n\nCONTASEÑA INVALIDA");
                            Console.ReadKey();
                        }
                    } while (exam == false);
                    Console.WriteLine("\nREDIRIGIENDO...");
                    Thread.Sleep(600);
                }
                acceso.WriteLine("{0}:{1}", nombreUsuario, ContraseñaAcceso);
                acceso.Close();
            } while (contraseña == false);

        }
        
    }
}
