public class Solution {
    public int SubarraySum(int[] nums, int k) {

        int result = 0;
        int currentSum = 0;

        Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();

        prefixSumCount[0] = 1;

        foreach(var num in nums)
        {
            currentSum+= num;

            if(prefixSumCount.ContainsKey(currentSum - k))
            {
                result += prefixSumCount[currentSum-k];
            }

            if(prefixSumCount.ContainsKey(currentSum))
            {
                prefixSumCount[currentSum]++;
            }
            else
                prefixSumCount[currentSum] = 1;
        }

        return result;
      
    }
}