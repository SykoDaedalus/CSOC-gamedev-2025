using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmallestNumber
{
    
    public static int GetSmall(int[] digits)
    {
        // write code here
        // Sort the digits in ascending order
        System.Array.Sort(digits);
        // If the first digit is 0, find the first non-zero digit and swap it with the first digit
        if (digits[0] == 0)
        {
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                {
                    // Swap the first digit with the first non-zero digit
                    int temp = digits[0];
                    digits[0] = digits[i];
                    digits[i] = temp;
                    break;
                }
            }
        }
        // Convert the digits back to an integer
        int result = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            result = result * 10 + digits[i];
        }
        return result;
    }
}
