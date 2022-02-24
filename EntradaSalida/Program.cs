using System;

namespace EntradaSalida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio de Entrada y Salida de Datos:");
            //Entrada de Datos.
            Console.WriteLine("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            //Salida de Datos.
            Console.WriteLine("Hola, "+nombre);
        }
    }
}
