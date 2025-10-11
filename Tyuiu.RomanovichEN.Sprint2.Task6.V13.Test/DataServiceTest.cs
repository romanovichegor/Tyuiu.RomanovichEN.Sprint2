using Tyuiu.RomanovichEN.Sprint2.Task6.V13.Lib;
namespace Tyuiu.RomanovichEN.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int g, m, n;
            g = 1990;
            m = 5;
            n = 6;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "7.5.1990";
            Assert.AreEqual(res, wait);
        }
    }
}
