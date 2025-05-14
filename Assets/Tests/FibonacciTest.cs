using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEngine;

public class FibonacciTest
{
    [Test]
    public void FibonacciBasicTests()
    {
        Assert.AreEqual(0, Fibonacci.FibNum(0));
        Assert.AreEqual(1, Fibonacci.FibNum(1));
        Assert.AreEqual(1, Fibonacci.FibNum(2));
        Assert.AreEqual(2, Fibonacci.FibNum(3));
        Assert.AreEqual(3, Fibonacci.FibNum(4));
        Assert.AreEqual(5, Fibonacci.FibNum(5));
        Assert.AreEqual(8, Fibonacci.FibNum(6));
        Assert.AreEqual(13, Fibonacci.FibNum(7));
        Assert.AreEqual(21, Fibonacci.FibNum(8));
        Assert.AreEqual(34, Fibonacci.FibNum(9));
        Assert.AreEqual(55, Fibonacci.FibNum(10));
        Assert.AreEqual(6765, Fibonacci.FibNum(20));
        Assert.AreEqual(586268941, Fibonacci.FibNum(50));
        Assert.AreEqual(242234, Fibonacci.FibNum(100));
        Assert.AreEqual(843925499, Fibonacci.FibNum(150));
        Assert.AreEqual(69256820, Fibonacci.FibNum(200));
        Assert.AreEqual(365010934, Fibonacci.FibNum(500));
    }

    [Test]
    public void FibonacciEdgeCaseTest()
    {
        const int MOD = 1_000_000_007;
        int result = Fibonacci.FibNum(1_000_000);
        Assert.GreaterOrEqual(result, 0);
        Assert.Less(result, MOD);
    }
}
