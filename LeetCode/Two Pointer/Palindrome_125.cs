public class Palindrome_125
{
    public  bool IsPalindrome(string s)
    {
        // I will be using Two pointer approch as transverse through string from both side of string and ignore other then alphanumeric charcter
        int l = 0;              
        int r =  s.Length-1;       // right
        while(l< r)
        {
            // if any of character is not is alpha numeric then we can skip it.
            while(l<r && !char.IsLetterOrDigit(s[l]))
            {
                l++;
            }
            while(l<r && !char.IsLetterOrDigit(s[r]))
            {
                r--;
            }
            // check if charcter miss matches , it is not a palindrome string so we can Return false.
            if(char.ToLower(s[l]) != char.ToLower(s[r]))
            {
                return false;
            }
            // move to next ones.
            l++;
            r--;
        }
        return true;;
    }

}