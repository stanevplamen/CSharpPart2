using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GivenNumberCounter;

namespace TestApp04
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCounter1()
        {
            int result = CounterProgram.Counter(1);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestCounter2()
        {
            int result = CounterProgram.Counter(2);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestCounter3()
        {
            int result = CounterProgram.Counter(3);
            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void TestCounter4()
        {
            int result = CounterProgram.Counter(4);
            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void TestCounter5()
        {
            int result = CounterProgram.Counter(5);
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void TestCounter6()
        {
            int result = CounterProgram.Counter(6);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestCounter7()
        {
            int result = CounterProgram.Counter(7);
            Assert.AreEqual(4, result);
        }
    }
}
