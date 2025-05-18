using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class SmallestNumber
{
    /*
     * Problem: Given a array of digits, form the smallest possible number using all of them.
     * 
     * You must use all the digits exactly once.
     * The length of number should be equal to length of array
     * 
     * Example:
     *  - Input: [1, 2, 3, 4] → Output: 1234
     *  - Input: [0, 0, 1, 0] → Output: 1000
     * 
     * Implement the method to return the smallest number that can be formed using the digits.
     */
    public static int GetSmall(int[] digits)
    {
        // write code here
        int l = digits.Length;
        if (digits.Count(x => x == 0) == l)
        {
            return 0;
        }

        Array.Sort(digits);

        int idx =0;

        for (int i = 0; i < l; i++)
        {
            if (digits[i] != 0)
            {
                idx = i;
                break;
            }
        }

        int[] newDigits = new int[l];

        newDigits[0] = digits[idx];
        int j = 1;
        for (int i = 0; i < l; i++)
        {
            if (i != idx)
            {
                newDigits[j++] = digits[i];
            }
        }

        int num = 0;
        foreach (int d in newDigits)
        {
            num = num * 10 + d;
        }

        return num;
    }
    //(P.S take care of edge cases, like what if all digits are zeroes?😜)
    /*This problem is definitely slightly on the tougher side, nevertheless it will
     * in developing logical and critical thinking.
     * You can skip this problem if you want  
    */
}
