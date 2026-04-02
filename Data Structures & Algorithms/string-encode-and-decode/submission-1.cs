public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder builder = new StringBuilder();

        foreach(var str in strs)
        {
            builder.Append(str.Length);
            builder.Append("#");
            builder.Append(str);
        }

        return builder.ToString();
    }

    public List<string> Decode(string s) {

        List<string> strs = new List<string>();
        int i = 0;
        //5 # H e l l o 5 # w o  r  l  d
        //0 1 2 3 4 5 6 7 8 9 10 11 12 13

        //              i
        //                j

        while(i < s.Length)
        {
            int j = i;

            while(s[j] != '#')
            {
                j++;
            }

            int length = int.Parse(s.Substring(i, j));

            i = j +1;

            string word = s.Substring(i, length);

            i = i+ length;
        }

        return strs;

   }
}
