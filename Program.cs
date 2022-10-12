using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] placa = new int[10];


            Console.WriteLine("**MENU DE OPCIONES**");
            Console.WriteLine("1- Inicializar vectores");
            Console.WriteLine("2- Ingresar paso vehicular");
            Console.WriteLine("3- Consulta por numero de placa");
            Console.WriteLine("4- Modificar por numero de placa");
            Console.WriteLine("5- Reporte de todos los vectores");
            Console.WriteLine("6- Salir");
            Console.WriteLine("Escoge una de las opciones");

            String s1 = null;
            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    Console.WriteLine("Opcion numero 1");
                    break; 

                case "2":
                    Console.WriteLine("Registrar flujo vehicular");
                    Console.WriteLine("Ingrese wl numero de placa");
                    placa = int.Parse(Console.ReadLine());
                    


                    break;
                case "3":
                    Console.WriteLine("Opcion numero 3");
                    break;
                case "4":
                    Console.WriteLine("Opcion numero 4");
                    break;
                case "5":
                    Console.WriteLine("Opcion numero 5");
                  
                        break;
                case "6":
                    Console.WriteLine("Opcion numero 6");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;





            }
            Console.ReadKey();
        }
        
    }
}
