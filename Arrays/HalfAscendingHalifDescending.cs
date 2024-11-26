//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class HalfAscendingHalifDescending
//    {
//        static void Main(string[] args)
//        {
//            //5.WAP to half sort the array in ascending and half in descending
//            int[] arr = { 5, 13, 1, 4, 20 ,41,79,8};
//            int n = arr.Length;
//            // Sort entire array
//            for (int i = 0; i < n - 1; i++)
//            {
//                for (int j = i + 1; j < n; j++)
//                {
//                    if (arr[i] > arr[j])
//                    {
//                        int temp = arr[i];
//                        arr[i] = arr[j];
//                        arr[j] = temp;
//                    }
//                }
//            }
//            // Reverse second half
//            for (int i = n / 2, j = n - 1; i < j; i++, j--)
//            {
//                int temp = arr[i];
//                arr[i] = arr[j];
//                arr[j] = temp;
//            }
//            Console.WriteLine("Half-sorted Array: " + string.Join(", ", arr));
//        }
//    }
//}
