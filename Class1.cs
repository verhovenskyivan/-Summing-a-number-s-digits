using System;
public class Kata
{
    public static int SumDigits(int n)
    {
        n = Math.Abs(n);
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
}