using Tyuiu.GilevaAP.Sprint4.Task0.V19.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int[] Array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetMultOddArrEl(Array);
            int wait = 297675;
            Assert.AreEqual(wait, res);
        }
    }
}
