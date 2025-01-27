using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class Helper
    {
        public static void Swap(ref int X, ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }
        public static void BubbleSort(int[] arr)// 5, 8, 3, 4, 1, 9 //5,4,6,7,8,9, 
        {
            bool flag;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                flag = false;
                for (int j = 0; j < arr.Length -i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        flag = true;
                    }
                }
                if (!flag)
                    break;
            }
        }
    }
}
