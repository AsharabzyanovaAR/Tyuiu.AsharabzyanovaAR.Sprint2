using Tyuiu.AsharabzyanovaAR.Sprint2.Task7.V15.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint2.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1.5;
            double y = 1.2;
            bool wait = true;
            Assert.AreEqual(wait, ds.CheckDotInShadedArea(x, y));

        }
    }
}
