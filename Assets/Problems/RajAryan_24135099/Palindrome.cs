using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Palindrome
{
    /*
     * Problem: Check if a number is a palindrome.
     * 
     * A number is a palindrome if it reads the same backward as forward.
     * 
     * Example:
     *  - 121 is a palindrome (121 reversed is 121)
     *  - 123 is NOT a palindrome (123 reversed is 321)
     *  - 0 is a palindrome
     *  - 1221 is a palindrome
     * 
     * Implement the method to return true if the number is a palindrome, otherwise false.
     * number<=10^6
     */
    public static bool isPalindrome(int number)
    {
        string a = Convert.ToString(number);
        int i = 0;
        int j = a.Length - 1;

        while (i <= j)
        {
            if (a[i] != a[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}
