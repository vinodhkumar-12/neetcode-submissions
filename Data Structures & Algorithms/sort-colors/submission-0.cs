public class Solution {
    public void SortColors(int[] nums) {
        int start = 0;
        int end = nums.Length - 1;
        int middle = 0;

        while(middle <= end)
        {
            if(nums[middle] == 0)
            {
                SwapNumbers(nums, start, middle);
                start++;
                middle++;

            }
            else if(nums[middle] == 1 )
            {
                middle++;
            }
            else
            {
                SwapNumbers(nums, middle, end);
                end--;
            }
        }
    }


    public void SwapNumbers(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}