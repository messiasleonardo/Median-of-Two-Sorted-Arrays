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

            Dictionary<int, int> dictionaryValues = new Dictionary<int, int>();

            int count = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                dictionaryValues.Add(i, nums1[i]);
                count++;
            }
            for (int j = count, i = 0; i < nums2.Length; j++)
            {

                dictionaryValues.Add(j, nums2[i]);
                i++;
            }
            var dictionaryOrdering = dictionaryValues.OrderBy(x => x.Value).ToList();
            var countingIndex = dictionaryOrdering.Count;

            bool checkMiddleArray = CheckArrayIndex(dictionaryOrdering);

            if (checkMiddleArray)
            {
                return (double)(dictionaryOrdering[countingIndex / 2].Value);
            }

            if (countingIndex == 2)
            {
                return (double)(dictionaryOrdering[0].Value + dictionaryOrdering[1].Value) / 2;
            }

            bool isPrime = CheckIsPrime(countingIndex);


            if (isPrime)
            {
                int halfValue = countingIndex / 2;
                return (double)dictionaryOrdering[halfValue].Value;
            }


            else
            {
                int sum = 0;
                double result = 0;
                int index = 0;

                index = dictionaryOrdering.Count / 2;
                int[] medium = new int[2];

                medium[0] = dictionaryOrdering[index - 1].Value;
                medium[1] = dictionaryOrdering[index].Value;

                sum = medium[0] + medium[1];
                return result = (double)sum / 2;
            }

        }

        private bool CheckArrayIndex(List<KeyValuePair<int, int>> dictionaryOrdering)
        {
            int middleIndex = dictionaryOrdering.Count / 2;
            List<int> leftElements = new List<int>();
            List<int> rightElements = new List<int>();
            for (int i = 0; i < middleIndex; i++)
            {
                leftElements.Add(dictionaryOrdering[i].Value);
            }
            
            for (int x = middleIndex+1;x < dictionaryOrdering.Count; x++)
            {
                rightElements.Add(dictionaryOrdering[x].Value);
            }

            if (leftElements.Count == rightElements.Count)
            {
                return true;
            }
            return false;


        }



        private bool CheckIsPrime(int countingIndex)
        {
            int n, i, m = 0, flag = 0;
            n = countingIndex;
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    return false;
                }
            }
            if (flag == 0)
            {
                return true;
            }
            return false;
        }
    }
}
