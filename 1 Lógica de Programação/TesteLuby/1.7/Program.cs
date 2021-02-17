using System;
using System.Linq;

namespace _1._7
{
    class Program
    {
        // Foram feitas algumas alterações na linha:
        // ObterElementosPares(vetor) == new int { 2, 4 }; //true 
        // Para que pudesse ser feita a comparação entre os vetores


    // 1.7  Implemente a função abaixo que retorna um novo vetor com todos 
    //      elementos pares do vetor informado.
    static void Main(string[] args)
        {
            int[] vetor = new int[] { 1, 2, 3, 4, 5 };
            int[] vet2 = new int[] { 2, 4 };

            int[] vet1 = ObterElementosPares(vetor);//true

            int[] resultFinal;

            bool flag = false;

            //comparo os 2 vetores
            resultFinal = vet1.Intersect(vet2).ToArray();
            if (resultFinal.Count() == vet1.Count() &&
                resultFinal.Count() == vet2.Count()) {
                    flag = true;
            }

            Console.WriteLine(flag);
        }

        static int[] ObterElementosPares(int[] vetor)
        {
            int aux = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    aux += 1;
                }
            }


            int[] vet = new int[aux];
            aux = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    vet[aux] = vetor[i];
                    aux += 1;
                }

                
            }

            return vet;
        }
    }
}
