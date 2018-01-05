using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionLibrary.Tests
{
    [TestClass()]
    public class OptionTests
    {
        [TestMethod()]
        public void CalculateD1Test()
        {
            Option option = new Option();

            option.CalculateD1();

            Assert.AreEqual(option.D1, 0);
            
            option = new Option(100, 100, 0, 0.01, 1);

            option.CalculateD1();

            Assert.AreEqual(option.D1, 0);

            option = new Option(100, 100, 0.01, 0.01, 0);

            option.CalculateD1();

            Assert.AreEqual(option.D1, 0);

            option = new Option(100, 100, 0, 0.01, 0);

            option.CalculateD1();

            Assert.AreEqual(option.D1, 0);

            option = new Option(100, 0, 0.10, 0.01, 1);

            option.CalculateD1();

            Assert.AreEqual(option.D1, 0);

            option = new Option(100, 100, 0.10, 0.01, 1);

            option.CalculateD1();

            Assert.AreEqual(option.D1, 0.15, 0.01);

            option = new Option(100, 110, 0.10, 0.01, 1);

            option.CalculateD1();

            Assert.AreEqual(option.D1, -0.8, 0.05);

            option = new Option(100, 90, 0.10, 0.01, 1);

            option.CalculateD1();

            Assert.AreEqual(option.D1, 1.2, 0.02);
        }

        [TestMethod()]
        public void CalculateD2Test()
        {
            Option option = new Option();

            option.CalculateD2();

            Assert.AreEqual(option.D2, 0);

            option = new Option(40, 40, 0, 0.1, 1);

            option.CalculateD2();

            Assert.AreEqual(option.D2, 0);

            option = new Option(40, 40, 0.01, 0.1, 0);

            option.CalculateD2();

            Assert.AreEqual(option.D2, 0);

            option = new Option(40, 40, 0, 0.1, 0);

            option.CalculateD2();

            Assert.AreEqual(option.D2, 0);

            option = new Option(40, -10, 0.10, 0.1, 1);

            option.CalculateD2();

            Assert.AreEqual(option.D2, 0);

            option = new Option(40, 40, 0.10, 0.1, 1);

            option.CalculateD2();

            Assert.AreEqual(option.D2, 0.95);

            option = new Option(40, 45, 0.10, 0.1, 1);

            option.CalculateD2();

            Assert.AreEqual(option.D2, -0.2, 0.05);

            option = new Option(40, 35, 0.10, 0.1, 1);

            option.CalculateD2();

            Assert.AreEqual(option.D2, 2.3, 0.02);
        }

        [TestMethod()]
        public void CalculatePremiumTest()
        {
            Option option = new Option(10, 10, 0.1, 0.1, 0);

            option.CalculatePremium();

            Assert.AreEqual(option.Premium, 0);

            option = new Option(10, 15, 0.1, 0.1, 0);

            option.CalculatePremium();

            Assert.AreEqual(option.Premium, 5);

            option = new Option(80, 75, 0.1, 0.1, 0);

            option.CalculatePremium();

            Assert.AreEqual(option.Premium, 0);

            option = new Option(80, 90, 0.1, 0.1, 0.5);

            option.CalculatePremium();

            Assert.AreEqual(option.Premium, 0.5, 0.03);

            option = new Option(80, 150, 0.1, 0.1, 0.5);

            option.CalculatePremium();

            Assert.AreEqual(option.Premium, 0, 0.0001);

            option = new Option(80, 1, 0.1, 0.1, 0.5);

            option.CalculatePremium();

            Assert.AreEqual(option.Premium, 79, 0.05);

        }
    }
}