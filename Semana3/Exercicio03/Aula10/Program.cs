using System; // Arquivos em C#
using System.IO; //  para arquivos

namespace Aula1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arquivos = Directory.GetFiles(@"C:\");
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.ReadKey();
        }
    }
}