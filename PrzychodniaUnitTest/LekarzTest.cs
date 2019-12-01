using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrzychodniaUnitTest.ServiceReference1;

namespace PrzychodniaUnitTest
{
    [TestClass]
    public class LekarzTest
    {
        [TestMethod]
        public void DodajLekarza()
        {
            Lekarz lekarz = new Lekarz()
            {
                Imie = "Janusz",
                Nazwisko = "Kowalczewski"
            };

            Assert.IsTrue(WcfTest.Service.DodajLekarza(lekarz).Id != default);
        }

        [TestMethod]
        public void UsunLekarza()
        {
            var lekarze = WcfTest.Service.PobierzLekarzy();

            Random random = new Random();

            if (lekarze.Length == 0)
            {
                Assert.Fail("Brak lekarzy zwracanych przez serwis.");
                return;
            }

            Assert.IsTrue(WcfTest.Service.UsunLekarza(random.Next(0, lekarze.Length)));
        }
    }
}