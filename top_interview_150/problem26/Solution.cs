namespace Solution{
    public static class Solution{
        public static int RemoveDuplicates(int[] nums) {
        int len = nums.Length;
        if(len == 0){
            return 0;
        }
        if (len == 1){
            return 1;
        }
        int i = 0;
        int j;
        int val;
        while(i < len){
            val = nums[i];
            j = i+1;
            while( j < len && nums[j] == val){
                j++
            }
            if(j == len - 1){
                break;
            }
            for(int k = i+1; k<j;k++){
                nums[k] = nums[j];
            }
            i++;
        }
        return i;
    }
    }
}