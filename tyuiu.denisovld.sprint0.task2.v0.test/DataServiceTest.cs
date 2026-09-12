using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.denisovld.sprint0.Task2.v0.lib;
namespace tyuiu.denisovld.sprint0.task2.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "John";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, John", res);
        }
    }
}
