using Tyuiu.GilevaAP.Sprint4.Task2.V18.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            int result = ds.Calculate(array);
            int wait = 46080;
            Assert.AreEqual(wait, result);
        }
    }
}
