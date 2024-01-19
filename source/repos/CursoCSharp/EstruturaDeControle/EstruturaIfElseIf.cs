using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Qual a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0 && nota <= 10.0)
            {
                Console.WriteLine("Quadro de Honra");
            }
            else if (nota < 9 && nota >= 7.0)
            {
                Console.WriteLine("Aprovado, somente!");
            }
            else if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Que valor é esse?");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
