using System; // Arquivos em C#
using System.IO; //  para arquivos

namespace Aula1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "documentos.txt";
            string[] documentos = File.ReadAllLines(nomeDoArquivo);
            foreach (string documento in documentos)
            {
                Console.WriteLine(documento);
            }
            Console.ReadKey(true);
        }
    }
}