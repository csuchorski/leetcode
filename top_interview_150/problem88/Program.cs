
using Solution;

int[] nums1 = { 4, 5, 6, 0, 0, 0 };
int[] nums2 = { 1, 2, 3 };

int m = 3;
int n = 3;

int[] result = Solution.Solution.Merge(nums1, m, nums2, n);

foreach (int i in result)
{
    Console.WriteLine(i);
}