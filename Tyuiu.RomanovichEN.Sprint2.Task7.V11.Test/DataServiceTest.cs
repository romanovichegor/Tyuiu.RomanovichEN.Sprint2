using Tyuiu.RomanovichEN.Sprint2.Task7.V11.Lib;
namespace Tyuiu.RomanovichEN.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x, y;
            x = -0.5;
            y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
