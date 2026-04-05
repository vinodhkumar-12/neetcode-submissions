public class Solution {
    public List<int> MajorityElement(int[] nums) {

        int? candidate1 = null, candidate2 = null;
        int count1 = 0;
        int count2 = 0;


        foreach(var num in nums)
        {
            if(candidate1 == num)
            {
                count1++;
            }
            else if(candidate2 == num)
            {
                count2++;
            }
            else if(count1 == 0)
            {
                candidate1 = num;
                count1++;
            }
            else if(count2 == 0)
            {
                candidate2 = num;
                count2++;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        count1 = 0;
        count2 = 0;

        List<int> results = new List<int>();

        foreach(var num in nums)
        {
            if(num == candidate1)
                count1++;
            else if(num == candidate2)
                count2++;
        }

        if(count1 > ((nums.Length) / 3))
            results.Add(candidate1.Value);

        if(count2 > ((nums.Length) / 3))
            results.Add(candidate2.Value);

            return results;
        
    }


}