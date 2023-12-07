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
}