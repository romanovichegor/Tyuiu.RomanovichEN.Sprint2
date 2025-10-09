using Tyuiu.RomanovichEN.Sprint2.Task4.V3.Lib;
namespace Tyuiu.RomanovichEN.Sprint2.Task4.V3.Test

{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double z = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(x, res);
        }
    }
}
