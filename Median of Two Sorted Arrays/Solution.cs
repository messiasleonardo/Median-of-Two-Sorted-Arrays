using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                result.Add(i, nums1[i]);
                count++;
            }
            for (int j = count, i = 0; i < nums2.Length; j++)
            {

                result.Add(j, nums2[i]);
                i++;
            }

            var test = result;
            int sum = 0;
            for (int x = 0; x < result.Count; x++)
            {
                    sum += result + sum;
                //for (int i = x; i < result.Count; i++)
                //{
                //}

            }

            var finaltest = sum;
            var a = sum / result.Count;

            return a;
        }
    }
}
