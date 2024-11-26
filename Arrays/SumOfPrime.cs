//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class SumOfPrime
//    {
//        public static Boolean IsPrime(int num)
//        {
//            if (num < 2) return false;
//            for (int i = 2; i * i <= num; i++)
//            {
//                if (num % i == 0)
//                    return false;
//            }
//            return true;
//        }
//        static void Main(string[] args)
//        {
//            //1.Sum of prime number in array
//            int[] arr = { 1, 2, 3, 4, 5, 6 ,13};
//            int primeSum = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (IsPrime(arr[i]))
//                    primeSum += arr[i];
//            }
//            Console.WriteLine("Sum of prime numbers: " + primeSum);
//        }
//    }
//}
