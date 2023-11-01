using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingC_
{
    internal class Frequency
    {
        public static Dictionary<int,string> count(int[] nums)
        {
            Dictionary<int,string> result = new Dictionary<int,string>();
            int count = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j<nums.Length;j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }

                try
                {
                    result.Add(nums[i], count + " times");
                }catch (Exception e) { }
              

                
                count = 0;
            }

            return result;
        }
    }
}
