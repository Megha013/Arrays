//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class SortArray
//    {
//        static void Main(string[] args)
//        {
//            //3.Sort an array
//            int[] arr = { 5, 13, 1, 41, 2 ,11};
//            for (int i = 0; i < arr.Length - 1; i++)
//            {
//                for (int j = i + 1; j < arr.Length; j++)
//                {
//                    if (arr[i] > arr[j])
//                    {
//                        int temp = arr[i];
//                        arr[i] = arr[j];
//                        arr[j] = temp;
//                    }
//                }
//            }
//            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
//        }
//    }
//}
