using System;
using System.Threading.Tasks;

namespace Packtpub.KunalChowdhury.Demos
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class ServiceContext
    {
        public async ValueTask<long> GetValue()
        {
            return await Task.Run<long>(() => 5000);
        }
    }
}
