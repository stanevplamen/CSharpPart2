using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodAndTest;


[TestClass]
public class MethodTest
{
    [TestMethod]
    public void TestMethod1()
    {
        string result = Program.PrintApp("Peter");
        Assert.AreEqual("Hello, Peter", result);
    }
    [TestMethod]
    public void TestMethod2()
    {
        string result = Program.PrintApp("Ivan");
        Assert.AreEqual("Hello, Ivan", result);
    }
    [TestMethod]
    public void TestMethod3()
    {
        string result = Program.PrintApp("Mitko");
        Assert.AreEqual("Hello, Mitko", result);
    }
    [TestMethod]
    public void TestMethod4()
    {
        string result = Program.PrintApp("Misho");
        Assert.AreEqual("Hello, Misho", result);
    }
    [TestMethod]
    public void TestMethod5()
    {
        string result = Program.PrintApp("Nasko");
        Assert.AreEqual("Hello, Nasko", result);
    }
}
