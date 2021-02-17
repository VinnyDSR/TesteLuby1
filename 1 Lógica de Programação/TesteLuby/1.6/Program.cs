using System;

namespace _1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularDiferencaData("10122020", "25122020") == 15);
        }

        private static int CalcularDiferencaData(string v1, string v2)
        {
            DateTime dataConvertidaV1 = new DateTime();
            DateTime dataConvertidaV2 = new DateTime();
            // data1 = Convert.ToDateTime(v1);

            var dataCorrigidaV1 = v1.Insert(2, "-").Insert(5, "-");
            var dataCorrigidaV2 = v2.Insert(2, "-").Insert(5, "-");

            dataConvertidaV1 = Convert.ToDateTime(dataCorrigidaV1);
            dataConvertidaV2 = Convert.ToDateTime(dataCorrigidaV2);

            return (int)dataConvertidaV2.Subtract(dataConvertidaV1).TotalDays;
        }
    }
}
