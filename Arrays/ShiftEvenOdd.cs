//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class ShiftEvenOdd
//    {
//        static void Main(string[] args)
//        {
//            //9.Shift even before odd
//            int[] arr = { 1, 2, 3, 4, 5, 6 };
//            int n = arr.Length;
//            int[] result = new int[n];
//            int index = 0;

//            // Add even numbers first
//            for (int i = 0; i < n; i++)
//            {
//                if (arr[i] % 2 == 0)
//                {
//                    result[index] = arr[i];
//                    index++;
//                }
//            }

//            // Add odd numbers next
//            for (int i = 0; i < n; i++)
//            {
//                if (arr[i] % 2 != 0)
//                {
//                    result[index] = arr[i];
//                    index++;
//                }
//            }

//            // Print the result
//            Console.Write("Even before Odd: ");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(result[i] + " ");
//            }
//            Console.WriteLine();

//        }
//    }
//}
