using System; // Arquivos em C#
using System.IO; //  para arquivos

namespace Aula1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "documentos.txt";

            string conteudo = File.ReadAllText(nomeDoArquivo);
            Console.WriteLine("conteúdo do arquivo" + conteudo);
            Console.WriteLine("\n");

            File.AppendAllText(nomeDoArquivo, "Um outro arquivo");

            conteudo = File.ReadAllText(nomeDoArquivo);
            Console.WriteLine("conteúdo do arquivo" + conteudo);
            Console.WriteLine("\n");
            
            Console.ReadKey(true);
        }
    }
}