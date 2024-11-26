//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class SecondHighest
//    {
//        static void Main(string[] args)
//        {
//            //4.second highest number w / o sorting
//            int[] arr = { 5, 13, 1, 41, 20 };
//            int max = arr[0], secondMax = int.MinValue;
//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (arr[i] > max)
//                {
//                    secondMax = max;
//                    max = arr[i];
//                }
//                else if (arr[i] > secondMax && arr[i] != max)
//                {
//                    secondMax = arr[i];
//                }
//            }
//            Console.WriteLine("Second highest number: " + secondMax);
//        }
//    }
//}
