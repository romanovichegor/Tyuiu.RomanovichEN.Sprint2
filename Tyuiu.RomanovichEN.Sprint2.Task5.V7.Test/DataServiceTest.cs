using System.Net.Http.Headers;
using Tyuiu.RomanovichEN.Sprint2.Task5.V7.Lib;
namespace Tyuiu.RomanovichEN.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int n = 1;
            int startYear = 1990;
            string wait = "Февраль";
            Assert.AreEqual(ds.FindMonthName(startYear,n), wait);

        }
    }
}
