using Tyuiu.GilevaAP.Sprint4.Task5.V28.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { {1, 2, 3, -4, -5},
                                            {-5, -3, -4, -5, 3},
                                            {1, 1, 1, 0, 1},
                                            {2, 3, 4, 5, 6},
                                            {1, 2, 3, 0, -2} };
            int[,] result = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] { {1, 2, 3, 0, 0},
                                          {0, 0, 0, 0, 3},
                                          {1, 1, 1, 0, 1},
                                          {2, 3, 4, 5, 6},
                                          {1, 2, 3, 0, 0} };
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
