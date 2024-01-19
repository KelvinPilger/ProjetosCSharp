using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresAritmeticos
    {
        public static void Executar()
        {

            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine($"O preço final do produto é: R${totalComDesconto}");

            Console.Write("Qual é o seu peso? (kg) ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual é sua Altura? (m) ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imc = peso / Math.Pow(altura, 2); // Math.Pow equivale a potência (Base, Expoente) [altura * altura
            Console.WriteLine($"IMC é: {imc}.");

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); // Operador Módulo (%) [O resto da divisão]
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
