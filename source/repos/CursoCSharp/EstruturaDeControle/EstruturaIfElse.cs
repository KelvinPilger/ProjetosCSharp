using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar()
        {
            Console.Write("Qual a nota: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Você não fez mais que sua obrigação!");
            } 
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Você é a Vergonha da Profissión!");
            }
            
        }
    }
}
