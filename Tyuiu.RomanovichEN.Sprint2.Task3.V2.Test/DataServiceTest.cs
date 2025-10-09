using Tyuiu.RomanovichEN.Sprint2.Task3.V2.Lib;
namespace Tyuiu.RomanovichEN.Sprint2.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 1.5;
            double res = ds.Calculate(x);
            Assert.AreEqual(res, wait);
        }
    }
}
