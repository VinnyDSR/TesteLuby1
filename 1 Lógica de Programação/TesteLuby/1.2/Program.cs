using System;

namespace ConsoleApp2
{
    class Program
    {
        /*  1.2 Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme valores:
            Tipo: "basic" fator multiplicação do prêmio: 1
            Tipo: "vip" fator multiplicação do prêmio: 1.2
            Tipo: "premium" fator multiplicação do prêmio: 1.5
            Tipo: "deluxe" fator multiplicação do prêmio: 1.8
            Tipo: "special" fator multiplicação do prêmio: 2
            Regras
            A função também deverá provir um parâmetro para que seja passado fator de multiplicação próprio.
            Quando parâmetro de fator de multiplicação próprio for informado e válido o mesmo deve sobrescrever o cálculo do tipo de prêmio.
            O prêmio nunca deve ter um valor negativo ou igual a zero. */
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularPremio(100, "vip", null) == 120.00);//true
            Console.WriteLine(CalcularPremio(100, "basic", 3) == 300.00);//true

            


        }

        private static double CalcularPremio(int v1, string v2, int? p)
        {
            
            
            double aux = 0;
            if (p == null && v1 > 0)
            {
                switch (v2)
                {
                    case "basic":
                        aux = v1 * 1;
                        break;
                    case "vip":
                        aux = v1 * 1.2;
                        break;
                    case "premium":
                        aux = v1 * 1.5;
                        break;
                    case "deluxe":
                        aux = v1 * 1.8;
                        break;
                    case "special":
                        aux = v1 * 2;
                        break;
                }
                return aux;
            }
            else if(v1 > 0)
            {
                int p1 = p.GetValueOrDefault();
                aux = v1 * p1;
                return aux;
            }

            Console.WriteLine("O valor não pode ser 0 ou menor que 0");
            return 0;
        }
    }
}
