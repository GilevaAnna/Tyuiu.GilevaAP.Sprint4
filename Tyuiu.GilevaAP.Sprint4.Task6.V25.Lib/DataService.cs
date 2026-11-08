using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GilevaAP.Sprint4.Task6.V25.Lib
{
    public class DataService : ISprint4Task6V25
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, sport => sport.Length > 6); //количество элементов длина которых > 6
            return mas.Length;
        }
    }
}
