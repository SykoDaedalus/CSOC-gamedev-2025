using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Armstrong
{
    public static bool IsArmstrong(int number)
    {
        // write code here
        // just return true or false;
        int copy = number;
        int sum = 0;
        int digits = 0;
        while (copy > 0)
        {
            copy /= 10;
            digits++;
        }
        copy = number;
        while (copy > 0)
        {
            int digit = copy % 10;
            sum += (int)Mathf.Pow(digit, digits);
            copy /= 10;
        }
        if (sum == number)
            return true;
        else
        return false;
    }
}
