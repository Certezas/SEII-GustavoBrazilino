using System; // Arquivos em C#
using System.IO; //  para arquivos

namespace Aula1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string diretorio = "pasta";

            if(Directory.Exists(diretorio))
            {
                Console.WriteLine("Diretório existe!");
            }
            else
            {
                Console.WriteLine("Diretório não existe!");
            }

            Console.ReadKey(true);
        }
    }
}