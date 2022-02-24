using System;

namespace LeerTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos números:");
            Console.Write("Ingrese número 1: ");
            string  dato1 = Console.ReadLine();
            int n1 = int.Parse(dato1);

            Console.Write("Ingresa número 2: ");
            string dato2 = Console.ReadLine();
            int n2 = int.Parse(dato2);

            int Suma = (n1 + n2);

            Console.WriteLine("El resultado de la suma es: {0}", Suma);
        }
    }
}
