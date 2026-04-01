public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqMap= new Dictionary<int, int>();

        foreach(var num in nums)
        {
            if(freqMap.ContainsKey(num))
            {
                freqMap[num]++;
            }
            else
                freqMap[num] = 1;
        } 

        PriorityQueue<int,int> minimumHeap = new PriorityQueue<int,int>();

        foreach(var entry in freqMap)
        {
            minimumHeap.Enqueue(entry.Key, entry.Value);

            if(minimumHeap.Count > k)
                minimumHeap.Dequeue();
        }

        int[] results = new int[k];
        int index = 0;

        while(minimumHeap.Count > 0)
        {
            results[index++] = minimumHeap.Dequeue();
        }

        return results;
    }
}
