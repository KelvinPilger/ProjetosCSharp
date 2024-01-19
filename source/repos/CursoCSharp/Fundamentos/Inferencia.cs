using System;

namespace CursoCSharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo"; // Por meio das "" foi identificado que o valor inferido se tratava de uma (String)
            Console.WriteLine(nome + " Inferência (String)");

            // Quando utilizado o (var), já na declaração, precisa ser informado seu valor! 
            var idade = 32;
            Console.WriteLine("Idade: " + idade + " Inferencia (Int)");

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine("A Soma de A + B é: " + (a + b));
        }
    }

}