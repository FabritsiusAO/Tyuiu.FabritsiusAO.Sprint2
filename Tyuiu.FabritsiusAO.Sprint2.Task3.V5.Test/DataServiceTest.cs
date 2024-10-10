using System.Transactions;
using Tyuiu.FabritsiusAO.Sprint2.Task3.V5.Lib;

namespace Tyuiu.FabritsiusAO.Sprint2.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(-7, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(-0.083, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = -1;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.1, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = -10;
            double res = ds.Calculate(x);
            Assert.AreEqual(-1100.01, res);
        }
    }
}