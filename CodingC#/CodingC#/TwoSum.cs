using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingC_
{
    internal class TwoSum
    {
        public static int[] Sum(int[] nums, int target)
        {
            int[] result = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && j != i)
                    {
                        result[0] = i;
                        result[1] = j;

                    }
                }
            }

            return result;
        }
    }
}
