namespace Solution
{
    public static class Solution
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int writeIndex = m + n - 1;
            int guard1 = m - 1;
            int guard2 = n - 1;
            while (guard2 >= 0 && guard1 >= 0)
            {

                if (nums1[guard1] <= nums2[guard2])
                {
                    nums1[writeIndex] = nums2[guard2];
                    writeIndex--;
                    guard2--;
                    continue;
                }
                else
                {
                    nums1[writeIndex] = nums1[guard1];
                    writeIndex--;
                    guard1--;
                    continue;
                }
            }
            if (guard1 == -1)
            {
                nums1[writeIndex] = nums2[guard2];
            }

            return nums1;
        }
    }
}