using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento (1 <--> 5): ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;

                case 1:             // Podem haver mais de um case, com mesma sentença!
                case 2:
                    Console.WriteLine("Ruim");
                    break;

                case 3:
                    Console.WriteLine("Regular");
                    break;

                case 4:
                    Console.WriteLine("Muito Bom");
                    break;

                case 5:
                    {
                        Console.WriteLine("Excelente");
                        break;
                    } // Podem haver blocos de código, dentro do case.
                    

                default:
                    Console.WriteLine("Valor Inválido!");
                    break;
            }

        }
    }
}
