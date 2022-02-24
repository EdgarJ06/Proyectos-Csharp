using System;

namespace Tipos_De_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte ByteConSigno = sbyte.MaxValue;
            byte ByteSinSigno = byte.MaxValue;
            short ShortConSigno = short.MaxValue;
            ushort ShortSinSingo = ushort.MaxValue;
            int IntConSigno = int.MaxValue;
            uint IntSinSigno = uint.MaxValue;
            long LongConSigno = long.MaxValue;
            ulong LongSinSigno = ulong.MaxValue;
            float FloatValor = float.MaxValue;
            double DoubleValor = double.MaxValue;
            decimal DecimalValor = decimal.MaxValue;

            Console.WriteLine("Tipos de Datos mostrados a continuación: ");
            Console.WriteLine("MAX[sbyte]: {0}", ByteConSigno);
            Console.WriteLine("MAX[byte]: {0}", ByteSinSigno);
            Console.WriteLine("MAX[short]: {0}", ShortConSigno);
            Console.WriteLine("MAX[ushort]: {0}", ShortSinSingo);
            Console.WriteLine("MAX[int]: {0}", IntConSigno);
            Console.WriteLine("MAX[unit]: {0}", IntSinSigno);
            Console.WriteLine("MAX[long]: {0}", LongConSigno);
            Console.WriteLine("MAX[ulong]: {0}", LongSinSigno);
            Console.WriteLine("MAX[float]: {0}", FloatValor);
            Console.WriteLine("MAX[double]: {0}", DoubleValor);
            Console.WriteLine("MAX[decimal]: {0}", DecimalValor);
        }
    }
}
