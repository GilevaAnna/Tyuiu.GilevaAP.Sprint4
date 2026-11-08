using Tyuiu.GilevaAP.Sprint4.Task6.V25.Lib;
namespace Tyuiu.GilevaAP.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            var sport = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int res = ds.Calculate(sport);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
