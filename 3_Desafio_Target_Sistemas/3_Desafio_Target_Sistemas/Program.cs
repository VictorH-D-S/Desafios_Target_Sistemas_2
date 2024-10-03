using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Desafio_Target_Sistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 12, SOMA = 0, K = 1;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine($"A soma da operação é igual a: {SOMA}");
            Console.ReadKey();
            return;
        }
    }
}
