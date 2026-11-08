using Tyuiu.GilevaAP.Sprint4.Task1.V21.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите длину массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[len];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < len; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i < len; i++)
            {
                Console.Write(Array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат произведения: ");
            int res = ds.Calculate(Array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}