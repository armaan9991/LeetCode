public class Longest_Substring_3
{
    public int Longest_substring(string s)
    {
        HashSet<char> longest_string  = new HashSet<char>();
        int left =0;
        int longest =0;
        for(int right = 0; right < s.Length; right++)
        {
            // keep on removing elements on left till we remove the duplicate
            while (longest_string.Contains(s[right]))
            {
                left++;
            }
            longest_string.Add(s[right]);
            longest = Math.Max(longest, right-left+1);
        }
        return longest;
    }
}