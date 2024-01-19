using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // F (Float) 1 Casa Decimal
            Console.WriteLine(valor.ToString("C")); // Currency (Moeda), Puxará R$, por estar configurado no Windows.
            Console.WriteLine(valor.ToString("P")); // Percentual
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR"); // Informar tipo de padrão de dados, moedas, etc.
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D5")); // "D (Qtd.)" Completar com zeros a esquerda, para chegar a quantidade informada.
        }
    }
}
