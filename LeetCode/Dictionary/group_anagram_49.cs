public class group_anagram_49
{
   
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary <string, List<string>> map = new Dictionary<string, List<string>>();   // Dictionary to store string  and list of same anagrams
        foreach (string str  in strs){
            char [] chars = str.ToCharArray(); // break string to array characters
            Array.Sort(chars); // sort those array characters

            string key = new string(chars);  // now that sorted will be a key.

            if(map.ContainsKey(key)){       // check if our dictionary has that key already or not.
                map[key].Add(str);      // if yess just add that 
            }
            else{
                map[key] = new List<string>();  // if our dictionary value was missing , then we create new list with key and add it .
                map[key].Add(str);
            }
        }
        return map.Values.ToList<IList<string>>();
    }

}