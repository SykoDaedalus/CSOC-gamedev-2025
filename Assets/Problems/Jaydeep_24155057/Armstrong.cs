using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class Armstrong
{
    public static bool IsArmstrong(int number)
    {
        int n = 0;
        int k = number;
        while (k != 0)
        {
            k = (int)k / 10;
            n = n + 1;
        }
        int b = 0;
        int a = n;
        int j = number;
        int h = 1;
        while (n != 0)
        {
            for (int i = 0; i < a; i++)
            {
                h *= j % 10;
            }
            n = n - 1;
            b = b + h;
            j = j / 10;
            h = 1;
        }
        if (b == number)
        {
            return true;
        }
        else
        {
            return false;
        }
        // write code here
        // just return true or false;
    }
    static void Main(string[] args)
    {
        Debug.Log(Armstrong.IsArmstrong(9474));
    }

}