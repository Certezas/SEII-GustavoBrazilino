using System; // Arquivos em C#
using System.IO; //  para arquivos

namespace Aula1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] documentos = { "Documento 1", "Documento 2",};
            string nomeDoArquivo = "documentos.txt";
            //File.WriteAllText(nomeDoArquivo, documentos[0]); //errado
            //File.WriteAllText(nomeDoArquivo, documentos[1]); 
            File.WriteAllLines(nomeDoArquivo, documentos);
            Console.WriteLine("O arquivo foi criado!");
            Console.ReadKey(true);
        }
    }
}

