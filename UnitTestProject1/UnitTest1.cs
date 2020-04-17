using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int param1 = 22;
            int param2 = 4;
            double expected = 5;

            // Act
            Calculos calc = new Calculos(param1, param2);
            
            // Assert
            double result = calc.Division();
            Assert.AreEqual(expected, result, "Test correcto");
        }
    }
}
