using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("               Return as Value");
            Console.WriteLine("**************************************************");
            DemoReturnAsValue();

            Console.WriteLine("**************************************************");
            Console.WriteLine("               Return as Reference");
            Console.WriteLine("**************************************************");
            DemoReturnAsReference();
        }

        #region Return as value
        public static void DemoReturnAsValue()
        {
            var count = 0;
            var index = 0;
            string[] names = { "Kunal", "Manika", "Dwijen" };
            string name = GetAsValue(names, index, ref count);

            Console.WriteLine("No. of strings in the array: " + count);
            Console.WriteLine("Name at {0}th index is: {1}\n", index, name);

            name = "Rajat";
            Console.WriteLine("The value of 'name' variable changed to: " + name);
            Console.WriteLine("The new name at {0}th index is still: {1}\n", index, GetAsValue(names, index, ref count));
        }

        public static string GetAsValue(string[] names, int index, ref int count)
        {
            count = names.Length;
            return names[index];
        }
        #endregion Return as value

        #region Return as reference
        public static void DemoReturnAsReference()
        {
            var count = 0;
            var index = 0;
            string[] names = { "Kunal", "Manika", "Dwijen" };


            ref string name = ref GetAsReference(names, index, ref count);

            Console.WriteLine("No. of strings in the array: " + count);
            Console.WriteLine("Name at {0}th index is: {1}\n", index, name);

            name = "Rajat";
            Console.WriteLine("The value of 'name' variable changed to: " + name);
            Console.WriteLine("The new name at {0}th index is now: {1}\n", index, GetAsReference(names, index, ref count));
        }

        public static ref string GetAsReference(string[] names, int index, ref int count)
        {
            count = names.Length;
            return ref names[index];
        }
        #endregion Return as reference
    }
}
