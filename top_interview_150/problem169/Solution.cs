
namespace Solution
{
    public static class Solution
    {
        public static int MajorityElement(int[] nums)
        {
            int max = 0;
            int majorityElement = nums[0];
            HashSet<int> uniqueNumbers = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqueNumbers.Contains(nums[i]))
                {
                    continue;
                }
                else
                {
                    uniqueNumbers.Add(nums[i]);
                }
                int count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        count++;
                    }
                }
                if (count > max)
                {
                    max = count;
                    majorityElement = nums[i];
                }
            }
            return majorityElement;
        }
    }
}

