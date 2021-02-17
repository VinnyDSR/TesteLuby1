using System;
using System.Collections;

namespace _1._3
{
    class Program
    {
        /*  1.3 Implemente a função abaixo para contar quantos números primos existe até o número informado.
           */
        static void Main(string[] args)
        {
            //Número primo: 2
            //Número primo: 3
            //Número primo: 5
            //Número primo: 7
            //Total de números primos: 4
            Console.WriteLine(ContarNumerosPrimos(10) == 4);//true 


        }

        private static int ContarNumerosPrimos(int v)
        {
            ArrayList a = new ArrayList();

            for (int i = 1; i < v/2; i++)
                {
                    if (v/i != 0)
                {
                    a.Add(i);
                }

                }

            return a.Count;
        }
    }
}
