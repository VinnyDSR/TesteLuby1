using System;
using System.Linq;

namespace _1._4
{
    class Program
    {
        // 1.4 Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string.
        static void Main(string[] args)
        {

            Console.WriteLine(CalcularVogais("Luby Software") == 4);//true


        }

        private static int CalcularVogais(string v)
        {
            char[] frase = v.ToLower().ToCharArray();
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            int qtd = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (vogais.Contains(frase[i]))
                {
                    qtd++;
                }
            }

            


            return qtd;
        }
    }
}
