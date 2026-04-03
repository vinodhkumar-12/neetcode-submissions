public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int length = nums.Length;
        int[] leftArray = new int[length];
        int[] rightArray = new int[length];
        int[] result = new int[length];

        for(int i = 0; i < length; i++)
        {
            if(i==0) {
                leftArray[i] = 1;
            }
            else
            {
                leftArray[i] = leftArray[i-1]*nums[i-1];
            }
        }

        for(int j = length-1; j >= 0; j--)
        {
            if(j == length-1){
                rightArray[j] = 1;
            }
            else
            {
                rightArray[j] = rightArray[j+1]*nums[j+1];
            }
        }

        for(int i = 0; i<length; i++)
        {
            result[i] = leftArray[i] * rightArray[i];
        }

        return result;
        
    }
}
                