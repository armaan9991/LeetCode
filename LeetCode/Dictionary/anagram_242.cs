public class anagram_242{
    public bool IsAnagram(string s , string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(char c in s)
        {
            if (!map.ContainsKey(c))
            {
                map[c] = 0;        // if map was missing have the value earlier.
            }
            map[c]++;
        }
        foreach(char c in t)
        {
            if (!map.ContainsKey(c))
            {
                map[c] = 0;
            }
            map[c]--;
            if  (map[c] != 0)
            {
                return false;
            }
        }
      return true;
        
    }
}