using System; // Arquivos em C#
using System.IO; //  para arquivos

namespace Aula1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string arquivo = "arquivo.txt";
            string texto = File.ReadAllText(arquivo);
            Console.WriteLine("Conteúdo do arquivo: " + texto);
            Console.ReadKey(true);
        }
    }
}
