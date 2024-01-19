using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // Inverte o Sinal do Valor (Se positivo, negativo.) (Se negativo, positivo.)
            Console.WriteLine(!booleano); // ! (Negação Lógica), inverte o valor booleano.

            numero1++;
            Console.WriteLine(numero1);

            --numero2;
            Console.WriteLine(numero2);

            Console.WriteLine(numero1++ == --numero2); 
            // numero1 será incrementado após a comparação, numero2 será incrementado antes devido a posição dos sinais 
            // num++ (Menor Prioridade) [Depois Comparação]
            // ++num (Maior Prioridade) [Antes Comparação]

        }
    }
}
