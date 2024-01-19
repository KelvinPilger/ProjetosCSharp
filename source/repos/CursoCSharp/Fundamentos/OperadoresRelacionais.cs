using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresRelacionais
    {
        public static void Executar()
        {

            // Igual (==)
            // Maior que (>)
            // Menor que (<)
            // Diferente de (!=)
            // Maior ou Igual (>=)
            // Menor ou Igual (<=)


            Console.Write("Digite a Nota do Aluno: ");
            double nota = double.Parse(Console.ReadLine());
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine($"Passou na média? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota <= 3.0}");



        }
    }
}
