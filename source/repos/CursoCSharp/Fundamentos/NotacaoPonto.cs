using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;


namespace CursoCSharp.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // (?) Somente irá acessar se a variável não estiver vazia.
        }
    }
}
	
