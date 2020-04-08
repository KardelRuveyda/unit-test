using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinanceApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SetCapital()
        {
            FinancialManager manager = new FinancialManager();
            manager.SetCapital(100.0);

            double expected = 100.0;
            double actual = manager.Capital;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_SetCapitalAsNegative()
        {
            FinancialManager manager = new FinancialManager();

            manager.SetCapital(-20);

            double expected = 0;
            double actual = manager.Capital;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_SetInterestRateNegative()
        {
            FinancialManager manager = new FinancialManager();
            manager.SetInterestRate(4);

            double expected = 0;
            double actual = manager.InterestRate;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void Test_SetInterestRate()
        {
            FinancialManager manager = new FinancialManager();

            manager.SetInterestRate(4);
            double expected = 0;
            double actual = manager.InterestRate;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Test_SetInterestGreatRate()
        {
            FinancialManager manager = new FinancialManager();

            manager.SetInterestGreatRate(26);
            double excepted = 0;
            double actual = manager.InterestRate;

            Assert.AreEqual(excepted,actual);
        }
    }
}

