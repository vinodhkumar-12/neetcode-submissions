public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int n = nums.Length;
        int[] result = new int[2];

        for(int i=0; i<=n ; i++)
        {
            for(int j=i+1;j<=n-1;j++)
            {
                if(nums[i] + nums[j] == target){
                    result[0] = i;
                    result[1] = j;

                    return result;
                }
            }
        }

        return result;
    }
}
