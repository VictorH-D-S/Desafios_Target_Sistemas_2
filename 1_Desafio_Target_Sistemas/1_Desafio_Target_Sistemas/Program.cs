﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Desafio_Target_Sistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()); int n_anterior = 0, n_atual = 1;

            if (numero == 0)
            {
                Console.WriteLine("O número 0 pertence à sequência de Fibonacci.");
                Console.ReadKey();
                return;
            }
            else if (numero == 1)
            {
                Console.WriteLine("O número 1 pertence à sequência de Fibonacci.");
                Console.ReadKey();
                return;
            }
                  
            if (n_atual == numero)
                {
                    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                    Console.ReadKey();
                    return;
            }

            int proximo = n_anterior + n_atual;
            n_anterior = n_atual;
            n_atual = proximo;
            

            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
            Console.ReadKey();
            return;
        }
    }
}
