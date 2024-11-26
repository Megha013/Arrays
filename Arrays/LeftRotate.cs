//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    public class LeftRotate
//    {
//        static void Main(string[] args)
//        {
//            //6.WAP to left rotate the array
//            //    ar = { 1, 2, 3, 4, 5 }
//            //    o / p: { 3,4,5,1,2}
//            int[] arr = { 1, 2, 3, 4, 5 };
//            int rotations = 2;
//            int n = arr.Length;
//            int[] rotated = new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                rotated[i] = arr[(i + rotations) % n];
//            }
//            Console.WriteLine("Left Rotated Array: " + string.Join(", ", rotated));

//        }
//    }
//}
