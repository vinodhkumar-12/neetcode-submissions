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

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(var entry in freqMap)
        {
            int freq = entry.Value;

            if(buckets[freq] == null)
            {
                buckets[freq] = new List<int>();
            }

            buckets[freq].Add(entry.Key);
        }

        List<int> results = new List<int>();

        for(int i = buckets.Length - 1; i>=0 && results.Count() < k; i--)
        {
            if(buckets[i] != null)
            {
                results.AddRange(buckets[i]);
            }
        }

        return results.Take(k).ToArray();
    }
}
