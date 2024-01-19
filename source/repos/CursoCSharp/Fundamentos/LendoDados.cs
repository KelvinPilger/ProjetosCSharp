using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // "1" --> 1 (Transformando String em Int)

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            // Invariant Culture, para ignorar os símbolos da máquina.
            // Utilizará o . como separador de casas decimais.

            Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos, e meu salário é de R${salario}.");
        }
    }
}
