using System; // Arquivos em C#
using System.IO; //  para arquivos

namespace Aula1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "documentos.txt";
            Console.WriteLine(File.Exists(nomeDoArquivo));

            Console.ReadKey(true);
        }
    }
}