using System;

namespace Ej_1_Sección_3
{
    /*Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario. 
    Agregar un case default.*/
    class Program
    {
        static void Main(string[] args)
        {
            //Pide al usuario que escriba un numero.
            Console.WriteLine("Escribe un número para decirte a que mes corresponde:");
            int numero = Int32.Parse(Console.ReadLine());

            //Codificación del case para los diferentes casos que se pueden dar y muestra el resultado.
            switch (numero){
                case 1:
                Console.WriteLine("El número {0} pertenece al mes de Enero.", numero);
                break;
                case 2:
                Console.WriteLine("El número {0} pertenece al mes de Febrero.", numero);
                break;
                case 3:
                Console.WriteLine("El número {0} pertenece al mes de Marzo.", numero);
                break;
                case 4:
                Console.WriteLine("El número {0} pertenece al mes de Abril.", numero);
                break;
                case 5:
                Console.WriteLine("El número {0} pertenece al mes de Mayo.", numero);
                break;
                case 6:
                Console.WriteLine("El número {0} pertenece al mes de Junio.", numero);
                break;
                case 7:
                Console.WriteLine("El número {0} pertenece al mes de Julio.", numero);
                break;
                case 8:
                Console.WriteLine("El número {0} pertenece al mes de Agosto.", numero);
                break;
                case 9:
                Console.WriteLine("El número {0} pertenece al mes de Septiembre.", numero);
                break;
                case 10:
                Console.WriteLine("El número {0} pertenece al mes de Octubre.", numero);
                break;
                case 11:
                Console.WriteLine("El número {0} pertenece al mes de Noviembre.", numero);
                break;
                case 12:
                Console.WriteLine("El número {0} pertenece al mes de Diciembre.", numero);
                break;
                default:
                Console.WriteLine("El número {0} no corresponde a ningún mes. Vuelve a ejecutar el programa para voler a intentarlo.", numero);
                break;
            }
        }
    }
}
