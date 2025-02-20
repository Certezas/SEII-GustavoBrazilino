using System; // Arquivos em C#
using System.IO; //  para arquivos

namespace Aula1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pasta = "Nova pasta";

            Directory.CreateDirectory(pasta);

            Console.ReadKey(true);
        }
    }
}