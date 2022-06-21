using Median_of_Two_Sorted_Arrays;
using Xunit;

namespace SolutionTests
{
    public class MedianofTwoSortedArraysTests
    {

        [Theory]
        [InlineData(new int[] {1,3}, new int[] {2}, 2)]
        [InlineData(new int[] {1,2}, new int[] {3,4}, 2.5)]
        [InlineData(new int[] {1,3}, new int[] {2,7}, 2.5)]
        [InlineData(new int[] { 0,0,0,0,0 }, new int[] { -1, 0, 0, 0, 0, 0, 1 }, 0)]
        [InlineData(new int[] { 3 }, new int[] { -2,-1 }, -1)]
        [InlineData(new int[] {  }, new int[] { 2,3 }, 2.5)]
        [InlineData(new int[] {  }, new int[] { 1,2,3,4,5 }, 3)]
        [InlineData(new int[] { 1 }, new int[] { 2,3,4,5,6,7,8,9 }, 5)]
        public void TestingValues(int[] nums1, int[] nums2, double expected)
        {
            Solution solution = new Solution();
            //Arrage

            //Act
            var actual = solution.FindMedianSortedArrays(nums1, nums2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}