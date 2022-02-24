using System;

namespace Condiciones
{
    class Program
    {
        static void Main(string[] args)
        {
          int NumeroEntero = int.Parse(Console.ReadLine());

          if(NumeroEntero == 7)
          Console.WriteLine("NumeroEntero es 7");
          else if (NumeroEntero < 0)
          Console.WriteLine("NumeroEntero es Negativo");
          else 
          Console.WriteLine("NumeroEntero no es ninguno de los casos programados");
        }
    }
}
