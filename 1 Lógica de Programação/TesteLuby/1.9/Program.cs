using System;
using System.Linq;

namespace _1._9
{
    class Program
    {
        // 1.9 Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um array de array de inteiros com no máximo dois elementos.

        static void Main(string[] args)
        {
            TransformarEmMatriz("1,2,3,4,5,6");// == new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }; //true 
        }

        private static int[][] TransformarEmMatriz(string v)
        {

            int[][] a = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } };
            //var separar = v. ;
            int c = 0, d = 0;
            //var array = v.Split(',');

            int[][] array1 = new int[3][3];

            for (int i=0; i< array.Length; i++)
                Console.WriteLine(array[i] + "-");

            for(int i=0; i<v.Length; i+=2)
            {
                c = v[i];
                d = v[i+1];
                array1[1] = { c, d  };
            }





            return a;
        }
    }
}
