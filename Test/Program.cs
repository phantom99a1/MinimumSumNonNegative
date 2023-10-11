using System;

namespace Test1
{
    public class Result
    {
        public static long number_of_bottle(long n,long k)
        {
            if (n < k) return n;

            long emptyBottle = n % k;
            long newBottle = n / k;
            long numberBottle = n;
            numberBottle += number_of_bottle(newBottle + emptyBottle, k)-emptyBottle;
            return numberBottle;
        }
    }
    public class Solution
    {        
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine(Result.number_of_bottle(n , 3));
            Console.ReadKey();
        }
    }
}
