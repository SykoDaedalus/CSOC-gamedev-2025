using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEngine;
using System.Collections.Generic;

public class SmallestNumberTest
{
    [Test]
    public void SmallestNumberTestSimplePasses()
    {
        Assert.AreEqual(1234, SmallestNumber.GetSmall(new int[] { 1, 2, 3, 4 }));
        Assert.AreEqual(1234, SmallestNumber.GetSmall(new int[] { 3, 2, 1, 4 }));
        Assert.AreEqual(1234, SmallestNumber.GetSmall(new int[] { 4, 3, 1, 2 }));
        Assert.AreEqual(1000, SmallestNumber.GetSmall(new int[] { 0, 0, 0, 1 }));
        Assert.AreEqual(1000, SmallestNumber.GetSmall(new int[] { 0, 0, 1, 0 }));
        Assert.AreEqual(1099, SmallestNumber.GetSmall(new int[] { 9, 9, 0, 1 }));
        Assert.AreEqual(9999, SmallestNumber.GetSmall(new int[] { 9, 9, 9, 9 }));
        Assert.AreEqual(9099, SmallestNumber.GetSmall(new int[] { 9, 0, 9, 9 }));
        Assert.AreEqual(0, SmallestNumber.GetSmall(new int[] { 0, 0, 0, 0 }));
    }

    [Test]
    public void FibonacciSimpleTest()
    {
        Assert.AreEqual(10012, SmallestNumber.GetSmall(new int[] { 1, 2, 1, 0, 0 }));

    }
}
