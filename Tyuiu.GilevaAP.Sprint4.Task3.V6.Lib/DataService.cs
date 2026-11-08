using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GilevaAP.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; // количество строк
            int cols = array.Length/rows; // количество столбцов
            int rindex = 1; // индекс 2 строки
            int max = array[rindex, 0];

            for (int j = 0; j < cols; j++)
            {
                if (array[rindex, j] > max)
                {
                    max = array[rindex, j];
                }
            }
            return max;
        }
    }
}
