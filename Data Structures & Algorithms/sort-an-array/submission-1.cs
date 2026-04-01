public class Solution {

    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length-1);
        return nums;
    }

    public void MergeSort(int[] nums, int leftIndex, int rightIndex)
    {
        if(leftIndex >= rightIndex)
            return;

        int middleIndex = leftIndex + ((rightIndex - leftIndex)/ 2);

        /*
            2mid = left + right;
            2mid - 2left = left + right - 2 left;
            2(mid - left) = right - left;
            mid - left = (right - left)/2;
            mid = left + ((right - left) / 2);
        */

        MergeSort(nums,leftIndex, middleIndex);
        MergeSort(nums,middleIndex+1, rightIndex);
        Merge(nums,leftIndex, middleIndex, rightIndex);

        
    }   

    public void Merge(int[] nums, int leftIndex, int middleIndex, int rightIndex)
    {
        int leftPointer = leftIndex;
        int rightPointer = middleIndex + 1 ;
        int tempPointer = 0;

        int[] tempArray = new int[rightIndex - leftIndex + 1];

        while(leftPointer <= middleIndex && rightPointer <= rightIndex)
        {
            if(nums[leftPointer] <= nums[rightPointer])
            {
                tempArray[tempPointer++] = nums[leftPointer++];
            }
            else
            {
                tempArray[tempPointer++] = nums[rightPointer++];
            }
        }

        while(leftPointer <= middleIndex)
        {
            tempArray[tempPointer++] = nums[leftPointer++];
        }

        while(rightPointer <= rightIndex)
        {
            tempArray[tempPointer++] = nums[rightPointer++];
        }

        for(int i = 0; i < tempArray.Length; i++ )
        {
            nums[leftIndex + i]  = tempArray[i];
        }
    }
}