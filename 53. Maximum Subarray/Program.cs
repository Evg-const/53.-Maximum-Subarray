using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { -2, -1, -3, 4, -1, 2, 1, -5, 4 };

            Console.WriteLine(Convert.ToString(MaxSubArray(input)));

            Console.Read();


            int MaxSubArray(int[] nums)
            {
                int temp =  nums[0];
                int ans = nums[0];

                for (int i = 0; i < nums.Length; i++)
                {                                      
                    temp = Math.Max(nums[i], (temp + nums[i]));
                    ans = Math.Max(temp, ans);

                }
                return ans;
            }




        }
    }
}
