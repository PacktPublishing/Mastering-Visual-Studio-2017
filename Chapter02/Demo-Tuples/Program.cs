using System;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            //var authorDetails = GetAuthor();
            //Console.WriteLine(authorDetails.Item1 + authorDetails.Item2);

            var authorDetails = GetAuthor();
            Console.WriteLine(authorDetails.AuthorName + authorDetails.Blog);
        }

        #region New changes to Tuples
        public static (string AuthorName, string Blog) GetAuthor()
        {
            return (AuthorName: "Kunal Chowdhury", Blog: "www.kunal-chowdhury.com");
        }

        //public static (string AuthorName, string Blog) GetAuthor()
        //{
        //    return ("Kunal Chowdhury", "www.kunal-chowdhury.com");
        //}

        //public static (string, string) GetAuthor()
        //{
        //    return ("Kunal Chowdhury", "www.kunal-chowdhury.com");
        //}
        #endregion New changes to Tuples

        #region Existing way using Tuple
        //public static Tuple<string, string> GetAuthor()
        //{
        //    return new Tuple<string, string>("Kunal Chowdhury",
        //                                     "www.kunal-chowdhury.com");
        //}
        #endregion Existing way using Tuple
    }
}
