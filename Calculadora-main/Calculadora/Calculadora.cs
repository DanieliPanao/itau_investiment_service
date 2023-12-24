using System;
using System.ComponentModel;
using System.Numerics;
using System.Collections.Generic;
namespace Calculadora
{
    public class Calculadora
    {
        public Stack<long> resultados {get;set;}

        public Calculadora()
        {
            resultados = new Stack<long>();
        }

        public void AdicionarResultado(long resultado)
        {
            resultados.Push(resultado);
        }   
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);
                AdicionarResultado(operacao.resultado);
                break;
                case '-': operacao.resultado = subtracao(operacao);
                AdicionarResultado(operacao.resultado);
                break;
                case '*': operacao.resultado = multiplicacao(operacao);
                AdicionarResultado(operacao.resultado);
                break;
                case '/': operacao.resultado = divisao(operacao);
                AdicionarResultado(operacao.resultado);
                break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }

        private long divisao(Operacoes operacao)
        {
            return operacao.valorA / operacao.valorB;
        }

        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
    }
}
