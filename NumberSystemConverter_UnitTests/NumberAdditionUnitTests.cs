using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number;

namespace Number_UnitTests
{
    [TestClass]
    public class NumberAdditionUnitTests
    {

        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void Number_Negative_ThrowsException_TestMethod()
        {
            var number = new Number.Number();
            number.AddNumbers("-1,3");
        }

    }

    [TestClass]
    public class NumberAdditionExpectedValuesUnitTests
    {

        [TestMethod]
        public void Number_Three_Expected_Result_I_TestMethod()
        {
            var number = new Number.Number();
            var result = number.AddNumbers("1,2");

            Assert.AreEqual(result, 3);

        }

    }
}
