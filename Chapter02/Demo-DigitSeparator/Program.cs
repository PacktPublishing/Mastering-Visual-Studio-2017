using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalValue1 = 1_50_000; // better than 150000
            var decimalValue2 = 25_91_50_000; // better than 259150000

            // you can use multiple underscores too
            var decimalValue3 = 25_91__50___000; // better than 259150000

            Console.WriteLine("Decimal Value 1: " + decimalValue1);
            Console.WriteLine("Decimal Value 2: " + decimalValue2);
            Console.WriteLine("Decimal Value 3: " + decimalValue3);

            var binaryValue = 0b1010_1011_1100_1101_1110_1111;
            var hexadecimalValue = 0xAB_C_0_D_EF_578;

            Console.WriteLine("\nBinary Value: " + binaryValue);
            Console.WriteLine("Hexadecimal Value: " + hexadecimalValue+"\n\n");
        }
    }
}
