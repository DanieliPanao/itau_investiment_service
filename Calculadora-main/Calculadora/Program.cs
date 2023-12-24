using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();
            Console.WriteLine("Operações iniciais:");
             
            while (filaOperacoes.Count > 0)
            {
                ImprimirOperacoes();
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
            }

            void ImprimirOperacoes()
            {
                Console.WriteLine("Operações a serem processadas:");
                foreach (var operacao in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}", operacao.valorA, operacao.operador, operacao.valorB);
                }
                Console.WriteLine();
            }

            ImprimirPilhaResultados(calculadora);
        }

        static void ImprimirPilhaResultados(Calculadora calculadora)
        {
            Console.WriteLine("\nPilha de Resultados:");
            foreach (var resultado in calculadora.resultados)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}