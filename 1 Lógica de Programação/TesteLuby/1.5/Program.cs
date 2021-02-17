using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace _1._5
{
    class Program
    { 
        //1.5 Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
        //Lembre-se que as entradas e saídas dos dados são strings que devem ser tratadas.
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00"); //true 
        }

        private static string CalcularValorComDescontoFormatado(string v1, string v2)
        {
            char[] frase = v1.ToLower().ToCharArray();
            String valor = "", valor1 = "";
            char[] numeros = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ',', '.'};
            double resultado;

            for (int i = 0; i < frase.Length; i++)
            {
                if (numeros.Contains(frase[i]))
                {
                    valor = valor + frase[i].ToString();
                }
            }

            frase = v2.ToLower().ToCharArray();
            
            for (int i = 0; i < frase.Length; i++)
            {
                if (numeros.Contains(frase[i]))
                {
                    valor1 = valor1 + frase[i].ToString();
                }
            }

            double valorint = System.Convert.ToDouble(valor);
            double valor1int = System.Convert.ToDouble(valor1);

            resultado = valorint * (valor1int/100);

            resultado = valorint - resultado;

            valor = resultado.ToString("C", CultureInfo.CurrentCulture);

            return valor;
        }
    }
}
