using System;
using System.Runtime.CompilerServices;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculateOne();
            //CalculateTwo(25, 7);
            //CalculateThree();

            //PrintMethodDetails();

            DisplayText();
        }

        #region New ways with C# 7.0
        public static void CalculateOne()
        {
            double a = 5, b = 3;

            double Sum(double x, double y) { return x + y; }
            double Subtract(double x, double y) { return x - y; }
            double Multiply(double x, double y) { return x * y; }

            void Print(string msg, double value) { Console.WriteLine(msg + value); }

            Print(string.Format("Sum of {0}, {1} is: ", a, b), Sum(a, b));
            Print(string.Format("Difference of {0}, {1} is: ", a, b), Subtract(a, b));
            Print(string.Format("Multiplication of {0}, {1} is: ", a, b), Multiply(a, b));
        }

        public static void CalculateTwo(int a, int b)
        {
            Print();

            void Print()
            {
                Console.WriteLine("Sum of {0}, {1} is: {2}", a, b, (a + b));
            }
        }

        public static void CalculateThree()
        {
            void Sum(int x, int y, out int result) => result = x + y;

            int retValue = 0;
            Sum(5, 3, out retValue);

            Console.WriteLine("Result: " + retValue);
        }

        public static void PrintMethodDetails()
        {
            void Print([CallerMemberName] string name = null,
                        [CallerLineNumber] int line = 0,
                        [CallerFilePath] string filePath = null)
            {
                Console.WriteLine("The method name is: " + name);
                Console.WriteLine("The method line no. is: " + line);
                Console.WriteLine("The file path is: " + filePath);
            }

            Print();
        }

        public static void DisplayText()
        {
            void Print()
            {
                Console.WriteLine("Print from local function");
            }

            Print();
        }

        public static void Print()
        {
            Console.WriteLine("Print from member method");
        }
        #endregion New ways with C# 7.0

        #region Old ways
        public double Sum(double x, double y) { return x + y; }

        public double Subtract(double x, double y) { return x - y; }

        public double Multiply(double x, double y) { return x * y; }
        #endregion Old ways
    }
}
