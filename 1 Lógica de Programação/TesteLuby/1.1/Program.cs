using System;

namespace TesteLuby
{
    class Program
    {
        //  1.1 Implemente a função abaixo para calcular fatorial de um número.
        static void Main(string[] args)
        {
            // 5! = 5 · 4 · 3 · 2 · 1 = 120
            bool a = CalcularFatorial(5) == 120;//true
            Console.WriteLine(a);
        }

        private static int CalcularFatorial(int v)
        {
            int aux = 1;
           

            for( ; v > 0; v--)
            {
                aux = v * aux;
            }
            
            return aux;
        }
    }
}