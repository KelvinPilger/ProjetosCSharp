using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace CursoCSharp.Fundamentos
{ 
    public class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + ", custa R$" + preco + "."); // Sem Interpolacão, Concatenação Padrão.

            Console.WriteLine("O {0} da marca {1}, custa R${2}.", nome, marca, preco); // Com Interpolação (EX: 1).

            Console.WriteLine($"A marca {marca}, é muito boa!"); // Com Interpolação (EX: 2) Usando o ($).

            Console.WriteLine($"O resultado de 1 + 1 é: {1 + 1}"); // Com Interpolação (EX: 2, Para Cálculo) Usando o ($).
        }
    }
}