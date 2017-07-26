using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Decimal Literal
            double height = 490;
            double width = 1290;

            Console.WriteLine("Height:" + height + " Width:" + width);
            #endregion Decimal Literal

            #region Hexdecimal Literal
            double heightInHex = 0x1EA; // equivalent to decimal 490
            double widthInHex = 0x50A; // equivalent to decimal 1290

            Console.WriteLine("Height:" + heightInHex + " Width:" + widthInHex);
            #endregion Hexdecimal Literal

            #region Binary Literal
            double heightInBinary = 0b1110110110; // equivalent to decimal 950
            double widthInBinary = 0b1001110110110; // equivalent to decimal 5046

            Console.WriteLine("Height:" + heightInBinary + " Width:" + widthInBinary);
            #endregion Binary Literal
        }
    }
}
