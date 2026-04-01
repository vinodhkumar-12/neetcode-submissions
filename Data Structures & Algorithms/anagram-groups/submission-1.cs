public class Solution {

    //act,cat
    //pots/tops/tops
    //hat

    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagram = new Dictionary<string, List<string>>();

        for (int i = 0; i <= strs.Length - 1 ; i++)
        {
            string name = strs[i];
            int[] count = new int[26];

            foreach (char c in name)
            {
                count[c - 'a']++;
            }

            string key = string.Join(',', count);

            if (!anagram.ContainsKey(key))
            {
                anagram[key] = new List<string>();
            }

            anagram[key].Add(name);
        }

        return anagram.Values.ToList();
    }
}
