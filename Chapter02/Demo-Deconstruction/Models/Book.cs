
namespace Packtpub.KunalChowdhury.Demos.Models
{
    public class Book
    {
        public void Deconstruct(out string Title, out string Author)
        {
            Title = "Mastering Visual Studio 2017";
            Author = "Kunal Chowdhury";
        }
    }
}
