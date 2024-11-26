//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class PosNegElements
//    {
//        static void Main(string[] args)
//        {
//            //7.WAP to replace the negative elements in an array with immediate left elements square
//            //ar = { 1, 2, -3, 2, -4, -6 }
//            //o / p ={ 1,2,4,2,4,16}
//            //here-> - 3 is replaced by square of 2 which is 4
//            int[] arr = { 1, 2, -3, 2, -4, -6 };
//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (arr[i] < 0)
//                {
//                    arr[i] = arr[i - 1] * arr[i - 1];
//                }
//            }
//            Console.WriteLine("Modified Array: " + string.Join(", ", arr));

//        }
//    }
//}
