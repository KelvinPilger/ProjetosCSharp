using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Conversao
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; // Conversão Implícita (Não há perigo de perda de Informação)
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // Cast de Double -> Int ---- Conversão Explícita
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString); // Conversão Explícita Utilizando (Parse)
            Console.WriteLine($"Sua idade é:  {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro); // Conversão Explícita Utilizando (Convert)

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); // (TryParse), tentativa de Converter, caso não conseguir, se desfaz do valor, e passa o número (0)
            Console.WriteLine("Resultado: {0}", numero1);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); // Declarado Variável dentro do TryParse
            Console.WriteLine("Resultado: {0}", numero2);

        }
    }
}
