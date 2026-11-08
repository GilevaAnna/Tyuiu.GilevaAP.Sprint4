using Tyuiu.GilevaAP.Sprint4.Task0.V19.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task0.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] Array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат произведения: ");
            int res = ds.GetMultOddArrEl(Array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
