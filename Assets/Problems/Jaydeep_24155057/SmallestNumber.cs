using Unity;
using System.Collections;
using System.Collections.Generic;

public class SmallestNumber
{
    public static int GetSmall(int[] digits)
    {
        Array.Sort(digits);

        int a = 0;
        if (digits[0] == 0)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                {
                    a = i;
                    break;
                }
            }
            int h = digits[a];
            digits[a] = digits[0];
            digits[0] = h;
        }

        for (int i = 0; i < digits.Length; i++)
        {
            Console.WriteLine(digits[i]);
           
        }
         Console.WriteLine(string.Join(" ", digits));
      
        return 0;
    }
    public static void Main(string[] args)
    {
        int[] mera = { 0, 0, 3, 0 };
        SmallestNumber.GetSmall(mera);
    }
    //(P.S take care of edge cases, like what if all digits are zeroes?😜)
    /*This problem is definitely slightly on the tougher side, nevertheless it will
     * in developing logical and critical thinking.
     * You can skip this problem if you want  
    */
}
