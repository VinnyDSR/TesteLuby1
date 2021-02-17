using System;
using System.Linq;

namespace _1._8
{
    class Program
    {
        //1.8 Implemente a função abaixo que deve buscar um ou mais 
        //elementos no vetor que contém o valor ou parte do valor 
        //informado na busca.
        static void Main(string[] args)
        {
            
            string[] vetor = new string[] {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero"
            };

            String[] a1 = new string[] { "John Doe", "Jane Doe" };
            String[] b1 = new string[] { "Alice Jones" };
            String[] c1 = new string[] { };

            String[] a2 = BuscarPessoa(vetor, "Doe"); //true
            bool a = TestaResultado(a1, a2);
            
            String[] b2 = BuscarPessoa(vetor, "Alice"); //true
            bool b = TestaResultado(b1, b2);

            String[] c2 = BuscarPessoa(vetor, "Louis"); //true;
            bool c = TestaResultado(c1, c2);

            Console.WriteLine(a + "\n" + b + "\n" + c);

            Console.WriteLine("O ultimo resultado fica como 'false' pois no github a questão cria 'new string[] { };',\ne a lógica que procura por 'Louis' retorna um vetor com 1 elemento, que seria 'Bobby Louis'");


        }

        private static bool TestaResultado(string[] s1, string[] s2)
        {
            bool flag = false;

            String[] resultFinal;

            resultFinal = s1.Intersect(s2).ToArray();
            if (resultFinal.Count() == s1.Count() 
                && resultFinal.Count() == s2.Count())
            {
                    flag = true;
            }

            return flag;
        }

        private static string[] BuscarPessoa(string[] vetor, string v) 
        {
            int aux = 0;

            

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].Contains(v)) 
                {
                    aux += 1;
                }
            }

            
            String[] result = new String[aux];
            
            aux = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].Contains(v))
                {
                    result[aux] = vetor[i];
                    aux += 1;
                }
            }
            

            return result;
        }
    }
}