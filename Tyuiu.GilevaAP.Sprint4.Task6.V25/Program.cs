using Tyuiu.GilevaAP.Sprint4.Task6.V25.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var sport = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

            Console.WriteLine("Исходный массив:");
            for (int i =0; i <= sport.Length - 1;i++)
            {
                Console.WriteLine(sport[i]);
                
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых больше 6: ");
            int res = ds.Calculate(sport);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}