using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProgram
{
    class BubbleSort
    {
        public static void BubbleSorting(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {                   
                    if (arr[j] > arr[j + 1])
                    {                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }
        public static void printArray(int[] arr)
        {
            int m = arr.Length;
            for (int k = 0; k < m; ++k)
            {
                Console.WriteLine(arr[k]);                
            }
        }
    }
}
