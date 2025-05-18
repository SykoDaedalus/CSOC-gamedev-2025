using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    /*
     * Problem: Return the nth Fibonacci number modulo 1e9 + 7.
     * 
     * The Fibonacci sequence is defined as:
     *  F(0) = 0
     *  F(1) = 1
     *  F(n) = F(n-1) + F(n-2) for n >= 2
     * 
     * You need to return F(n) % (1_000_000_007)
     * 
     * Constraints:
     *  - 0 <= number <= 10^6
     *  - Return result modulo 1_000_000_007 to prevent integer overflow
     * 
     * Example:
     *  - FibNum(0) => 0
     *  - FibNum(1) => 1
     *  - FibNum(5) => 5
     *  - FibNum(10) => 55
     * 
     * Tip: Use iteration instead of recursion to handle large inputs efficiently.
     */

    static int MOD = Convert.ToInt32(1e9 + 7);
    static int Fib(int n, Dictionary<int, int> memo)
    {
        if (n == 0) return 0;
        if (n == 1 || n == 2) return 1;

        if (memo.ContainsKey(n)) return memo[n];

        int value = (Fib(n - 1, memo) + Fib(n - 2, memo)) % MOD;
        memo.Add(n, value);

        return value;

    }
    public static int FibNum(int number)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();

        
        
        return Fib(number, memo);
    }
}
