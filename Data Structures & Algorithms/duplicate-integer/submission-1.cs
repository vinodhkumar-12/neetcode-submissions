public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();

        foreach(var num in nums)
        {
            if(seen.Contains(num))
            return true; //duplicate found

            seen.Add(num);
        }

        return false; //duplicate not found
    }
}