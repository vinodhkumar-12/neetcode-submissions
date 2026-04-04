public class Solution {
    public int LongestConsecutive(int[] nums) {

        HashSet<int> set = new HashSet<int>(nums);
        int longestStreak = 0;
    
        foreach(var num in nums)
        {
           if(!set.Contains(num-1))
           {
                int currentNum = num;
                int currentStreak = 1;

                while(set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
           }
        }

        return longestStreak;

    }
}
