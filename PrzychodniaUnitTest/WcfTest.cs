using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrzychodniaUnitTest.ServiceReference1;

namespace PrzychodniaUnitTest
{
    [TestClass]
    public class WcfTest
    {
        public static Service1Client Service => new Service1Client();

        [TestMethod]
        public void ServiceTest()
        {
            Assert.IsTrue(Service.Ping());
        }
    }
}