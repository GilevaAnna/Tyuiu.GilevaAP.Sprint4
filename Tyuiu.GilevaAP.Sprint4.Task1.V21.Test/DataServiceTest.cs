using Tyuiu.GilevaAP.Sprint4.Task1.V21.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6};
            int result = ds.Calculate(array);
            int wait = 1769472;
            Assert.AreEqual(wait, result);
        }
    }
}
