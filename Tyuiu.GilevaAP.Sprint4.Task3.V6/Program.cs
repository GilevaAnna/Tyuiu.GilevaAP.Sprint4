using Tyuiu.GilevaAP.Sprint4.Task3.V6.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { {8, 8, 3, 4, 5},
                                          {8, 6, 6, 4, 6},
                                          {3, 6, 5, 3, 4},
                                          {5, 6, 3, 7, 5},
                                          {7, 8, 5, 6, 6} };

            int rows = array.GetUpperBound(0) + 1; // количество строк
            int cols = array.Length / rows; // количество столбцов

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
 
            int res = ds.Calculate(array);
            Console.WriteLine("Максимальный элемент второй строки: " + res);
            Console.ReadKey();
        }
    }
}