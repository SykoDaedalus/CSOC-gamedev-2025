using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Armstrong
{
    /*
     * Problem: Check if a number is an Armstrong number.
     * 
     * An Armstrong number (also called a narcissistic number) is a number that is equal 
     * to the sum of its own digits each raised to the power of the number of digits.
     *
     * Example:
     *  - 153 is an Armstrong number because:
     *      1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
     *  - 9474 is an Armstrong number:
     *      9^4 + 4^4 + 7^4 + 4^4 = 6561 + 256 + 2401 + 256 = 9474
     *  - 123 is NOT an Armstrong number.
     *
     * Implement the method to return true if the number is Armstrong, otherwise false.
     */



    public static bool IsArmstrong(int number)
    {
        // write code here
        // just return true or false;
        int digits = 0;
        int n = number;
        while (n != 0)
        {
            n /= 10;
            digits++;
        }
        n = number;

        double sum = 0;

        while (n != 0)
        {
            int last = n % 10;
            n /= 10;
            sum += Math.Pow(last, digits);
        }

        if (number == Convert.ToInt32(sum))
        {
            return true;
        }

        return false;
    }
}
