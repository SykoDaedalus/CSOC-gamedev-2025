using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEngine;
using System.Collections.Generic;

public class ArmstrongTest
{
    [Test]
    public void ArmstrongNumberBasicTests()
    {
        Assert.IsTrue(Armstrong.IsArmstrong(0));
        Assert.IsTrue(Armstrong.IsArmstrong(1));
        Assert.IsTrue(Armstrong.IsArmstrong(153));
        Assert.IsTrue(Armstrong.IsArmstrong(370));
        Assert.IsTrue(Armstrong.IsArmstrong(371));
        Assert.IsTrue(Armstrong.IsArmstrong(407));
        Assert.IsTrue(Armstrong.IsArmstrong(9474));
        Assert.IsTrue(Armstrong.IsArmstrong(548834));

        Assert.IsFalse(Armstrong.IsArmstrong(10));
        Assert.IsFalse(Armstrong.IsArmstrong(100));
        Assert.IsFalse(Armstrong.IsArmstrong(123));
        Assert.IsFalse(Armstrong.IsArmstrong(9475));
    }

    [Test]
    public void ArmstrongLargeNumberEdgeCase()
    {

        Assert.IsFalse(Armstrong.IsArmstrong(999999));
    }
}
