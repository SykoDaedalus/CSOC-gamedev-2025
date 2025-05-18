using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    public static int FibNum(int number)
    {
        // Complete this function to return nth Fibonacci number.
        if (number == 0)
            return 0;
        if (number == 1)
            return 1;
        else
        {
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= number; i++)
            {
                c = (a + b) % 1000000007; // Calculate the next Fibonacci number
                a = b;
                b = c;
            }
            // Console.WriteLine(c);
            return c; // Return the result
        }
    }
}
