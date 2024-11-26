//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class ShiftZeros
//    {
//        static void Main(string[] args)
//        {
//            //8.Shift all zeros in the beginning of array/ Shift zeros at end
//            int[] arr = { 1, 0, 2, 0, 3 };
//            int n = arr.Length, index = 0;
//            int[] result = new int[n];
//            // Place zeros
//            for (int i = 0; i < n; i++)
//            {
//                if (arr[i] == 0)
//                {
//                    result[index++] = 0;
//                }
//            }
//            // Place non-zeros
//            for (int i = 0; i < n; i++)
//            {
//                if (arr[i] != 0)
//                {
//                    result[index++] = arr[i];
//                }
//            }
//            Console.WriteLine("Zeros at the beginning: " + string.Join(", ", result));

//        }
//    }
//}
