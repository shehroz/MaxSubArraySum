using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingAlgorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int[] arr = { -5, -1, -2 };
            //int[] arr = { -2, 1 ,3};
            //int[] arr = { -5,-1,-2 };
            //int[] arr = {-2,1 };
            int[] arr = {-2,-1 };
            int Sum = MaxSubArray(arr);
            Console.WriteLine("Max sum is :[" + Sum + "]");
            Console.ReadKey();
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return nums[0];
            int maxSum = nums[0];
            int maxSumRunning = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                maxSumRunning = maxSumRunning + nums[i];
                if (maxSum < maxSumRunning)
                    maxSum = maxSumRunning;
                if (maxSumRunning < 0)
                    maxSumRunning = 0;
            }
            return maxSum;
        }

    }

}
