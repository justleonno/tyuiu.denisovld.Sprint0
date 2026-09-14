using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.denisovld.sprint0.task4.v0.lib;
namespace tyuiu.denisovld.sprint0.task4.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MethodAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void MethodSubtractionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(15, 5));
        }
        [TestMethod]
        public void MethodMultiValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(5, 2));
        }
        [TestMethod]
        public void MethodDivisionValid()
        {
            Assert.AreEqual(10, DataService.Division(50, 5));
        }
    }
}
