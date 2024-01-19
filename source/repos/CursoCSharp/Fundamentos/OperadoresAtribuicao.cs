using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // Equivale a: num1 = num1 + 10; Atribuição Aditiva
            num1 -= 3;  // Equivale a: num1 = num1 - 3; Atribuição Subtrativa
            num1 *= 5;  // Equivale a: num1 = num1 * 5; Atribuição Multiplicatória
            num1 /= 2;  // Equivale a: num1 = num1 / 2; Atribuição Divisória
            Console.WriteLine("O valor final é: {0}", num1);

            int a = 1; // Atribuição literal
            int b = a; // Atribuição de variável

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} e {b}");

            dynamic c = new System.Dynamic.ExpandoObject(); 
            // Variável c && d, apontando para o mesmo espaço de memória, logo compartilham o mesmo valor.
            c.nome = "João";
            // Atribuição por Referência
            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
