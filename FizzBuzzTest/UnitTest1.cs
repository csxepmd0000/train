using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzNS;

namespace FizzBuzzTest;

[TestClass]
public class UnitTest1
{
    [TestMethod("入力が3の時出力はFizzである")]
    public void InputIs3()
    {
        int number = 3;
        string result = FizzBuzzC.CheckFizzBuzz(number);
        Assert.AreEqual("Fizz", result);
    }

    [TestMethod("入力が5の時出力はBuzzである")]
    public void InputIs5()
    {
        int number = 5;
        string result = FizzBuzzC.CheckFizzBuzz(number);
        Assert.AreEqual("Buzz", result);
    }

    [TestMethod("入力が15の時出力はFizzBuzzである")]
    public void InputIs15()
    {
        int number = 15;
        string result = FizzBuzzC.CheckFizzBuzz(number);
        Assert.AreEqual("FizzBuzz", result);
    }

    [TestMethod("入力が4の時出力は4である")]
    public void InputIs4()
    {
        int number = 4;
        string result = FizzBuzzC.CheckFizzBuzz(number);
        Assert.AreEqual("4", result);
    }

    [TestMethod("入力が100の時出力はBuzzである")]
    public void InputIs100()
    {
        int number = 100;
        string result = FizzBuzzC.CheckFizzBuzz(number);
        Assert.AreEqual("Buzz", result);
    }
    [TestMethod("入力が101の時出力はerrorである")]
    public void InputIs101()
    {
        int number = 101;
        string result = FizzBuzzC.CheckFizzBuzz(number);
        Assert.AreEqual("error", result);
    }
}