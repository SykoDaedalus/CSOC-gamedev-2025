using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEngine;
using System.Collections.Generic;

public class PalindromeTest
{
    [Test]
    public void PalindromeTestSimplePasses()
    {
        Assert.IsTrue(Palindrome.isPalindrome(121));
        Assert.IsTrue(Palindrome.isPalindrome(0));
        Assert.IsTrue(Palindrome.isPalindrome(1221));
        Assert.IsTrue(Palindrome.isPalindrome(1));
        Assert.IsTrue(Palindrome.isPalindrome(999999));

        Assert.IsFalse(Palindrome.isPalindrome(123));
        Assert.IsFalse(Palindrome.isPalindrome(10));
        Assert.IsFalse(Palindrome.isPalindrome(123456));
        Assert.IsFalse(Palindrome.isPalindrome(1000012));
    }

    [Test]
    public void PalindromeEdgeCases()
    {
        Assert.IsTrue(Palindrome.isPalindrome(2));
        Assert.IsFalse(Palindrome.isPalindrome(1000000));
    }
}
