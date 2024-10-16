using Microsoft.Testing.Platform.Extensions.Messages;
using Tyuiu.AsharabzyanovaAR.Sprint2.Task6.V12.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 3;
            int n = 10;
            Assert.AreEqual("09.03.2023", ds.FindDateOfPreviousDay(g,m,n));
        }
    }
}
