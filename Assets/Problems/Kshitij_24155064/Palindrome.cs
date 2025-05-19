using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Palindrome
{
    
    public static bool isPalindrome(int number)
    {
        // write code here
        // just return true or false
        int copy = number;
        int reversed = 0;
        while (copy > 0)
        {
            int digit = copy % 10;
            reversed = reversed * 10 + digit;
            copy /= 10;
        }
        if (reversed == number)
            return true;
        else
            return false;
    }
}
