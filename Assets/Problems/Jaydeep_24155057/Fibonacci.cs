using System.Collections;
using System.Collections.Generic;
using Unity;
public class Fibonacci : MonoBehaviour
{
   
    public static int FibNum(int number)
    {

        long f0 = 0;
        long f1 = 1;
        long fn = 1;
        for (int i = 2; i <= number; i++)
        {
            fn = f0 + f1;
            f0 = f1;
            f1 = fn;
        }

        // Console.WriteLine(fn % 1000000007);
        Debug.Log(fn % 1000000007);

        // Complete this function to return nth Fibonacci number.
        return 0;
    }
    public void Main(string[] args)
    {
        Fibonacci.FibNum(10);
    }
}
