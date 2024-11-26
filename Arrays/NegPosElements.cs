//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class NegPosElements
//    {
//        static void Main(string[] args)
//        {
//            //10.Shift negative before positive in array
//            int[] arr = { 1, -2, 3, -4, 5, -6 };
//            int n = arr.Length;
//            int[] result = new int[n];
//            int index = 0;

//            // Add negative numbers first
//            for (int i = 0; i < n; i++)
//            {
//                if (arr[i] < 0)
//                {
//                    result[index] = arr[i];
//                    index++;
//                }
//            }

//            // Add positive numbers next
//            for (int i = 0; i < n; i++)
//            {
//                if (arr[i] >= 0)
//                {
//                    result[index] = arr[i];
//                    index++;
//                }
//            }

//            // Print the result
//            Console.Write("Negative before Positive: ");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(result[i] + " ");
//            }
//            Console.WriteLine();

//        }
//    }
//}
