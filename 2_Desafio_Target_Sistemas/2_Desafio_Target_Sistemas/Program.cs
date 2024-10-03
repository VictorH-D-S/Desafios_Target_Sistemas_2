using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Desafio_Target_Sistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contador de caracteres "A" em palavras
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            int c = 0;

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra.Contains("a") || palavra.Contains("A")){
                    c++;    
                }

                if (i > 0)
                {
                    Console.WriteLine($"A palavra '{palavra}' contem {c}x a letra 'A'.");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine($"A palavra '{palavra}' não contem nenhuma letra 'A'.");
            Console.ReadKey();
            return;
        }
    }
}
