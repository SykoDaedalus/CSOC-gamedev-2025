using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Palindrome
{
   
    public static bool isPalindrome(int number)
    {
        string a = number.ToString();
        int len = a.Length;
        
        for (int i = 0; i < len / 2; i++)
        {
            if (a[i] != a[len - i - 1])
            {
                return false;
            }
        }
        return true;
        // write code here
        // just return true or false
    }
    public static void Main(string[] args)
    {
        // Console.WriteLine(Palindrome.isPalindrome(123221));
        Debug.Log(Palindrome.isPalindrome(123221));
    }
}
