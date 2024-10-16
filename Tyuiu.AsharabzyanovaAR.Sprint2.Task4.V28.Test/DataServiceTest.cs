using Tyuiu.AsharabzyanovaAR.Sprint2.Task4.V28.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            double wait = 16;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double wait = 1.787;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
