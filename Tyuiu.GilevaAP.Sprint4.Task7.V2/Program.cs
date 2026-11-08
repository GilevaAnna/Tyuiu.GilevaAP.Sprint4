using Tyuiu.GilevaAP.Sprint4.Task7.V2.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 4;
            int[,] matrix = new int[n, m];
            string value = "597643158942";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int index = 0;
            Console.WriteLine("\nмассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]}\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечетных элементов: ");
            int res = ds.Calculate(n, m, value);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}