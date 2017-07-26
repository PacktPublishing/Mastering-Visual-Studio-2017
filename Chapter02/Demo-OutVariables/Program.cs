using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region New ways of using 'out' variables
            string value = "125";

            // int.TryParse(value, out int result);
            int.TryParse(value, out var result);
            Console.WriteLine("The result is: " + result);
            #endregion New ways of using 'out' variables

            #region Old ways of using 'out' variables
            //int result = 0;
            //string value = "125";

            //int.TryParse(value, out result);

            //Console.WriteLine("The result is: " + result);
            #endregion Old ways of using 'out' variables
        }
    }
}
