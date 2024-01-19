using System;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Área da Circunferência
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A Área é: " + area);

            // Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está Chovendo? (" + estaChovendo + ")");

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos Inteiros!
            Console.WriteLine("Menor Valor Inteiro: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99F; // Lembrar do Sufixo "F" após o valor ser informado.
            Console.WriteLine("Preço do Computador: R$" + precoComputador);

            double valorDeMercadoDaApple = 10000000000.00; // Mais utilizado dos Reais
            Console.WriteLine("Valor de Mercado da Apple: R$" + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância Entre Estrelas: " + distanciaEntreEstrelas + " km/s");

            char letra = 'M';
            Console.WriteLine("Sexo do Cliente: " + letra);

            string texto = "Irei Me Tornar Um Desenvolvedor Desktop em C#!";
            Console.WriteLine(texto + " Amém...");
        }

    }
}
