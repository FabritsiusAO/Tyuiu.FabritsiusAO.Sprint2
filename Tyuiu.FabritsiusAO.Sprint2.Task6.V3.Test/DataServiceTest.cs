using Tyuiu.FabritsiusAO.Sprint2.Task6.V3.Lib;

namespace Tyuiu.FabritsiusAO.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("понедельник", ds.FindDayName(1));
            Assert.AreEqual("вторник", ds.FindDayName(2));
            Assert.AreEqual("среда", ds.FindDayName(3));
            Assert.AreEqual("четверг", ds.FindDayName(4));
            Assert.AreEqual("п€тница", ds.FindDayName(5));
            Assert.AreEqual("суббота", ds.FindDayName(6));
            Assert.AreEqual("воскресенье", ds.FindDayName(7));
            Assert.AreEqual("ѕор€дковый номер должен быть в промежутке от 1 до 7. «начение: 8", ds.FindDayName(8));
        }
    }
}