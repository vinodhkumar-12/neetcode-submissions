public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> map = new Dictionary<int, int>();
        for(int i=0; i< nums.Length; i++)
        {
            int difference = target - nums[i];

            if(map.ContainsKey(difference))
            {
                int j = map[difference];
                return new int[] {j,i};
            }

            if(!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        return new int[] {};
    }
}
