namespace Solution
{
    public static class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {

            int frontGuard = 0;
            int rearGuard = nums.Length - 1;

            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                if (nums[0] == val)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            while (frontGuard < nums.Length)
            {
                if (nums[frontGuard] == val)
                {
                    while (nums[rearGuard] == val && rearGuard > 0)
                    {
                        rearGuard--;
                    }
                    if (rearGuard <= frontGuard)
                    {
                        break;
                    }
                    (nums[rearGuard], nums[frontGuard]) = (nums[frontGuard], nums[rearGuard]);
                }
                frontGuard++;
            }
            return frontGuard;
        }
    }
}