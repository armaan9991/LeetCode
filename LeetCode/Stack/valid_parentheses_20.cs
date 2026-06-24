public class valid_parentheses_20 {
    public bool IsValid(string s) {
        Stack<char> c = new Stack<char>();
        for(int i=0;i<s.Length;i++){
            if (s[i] == '('  || s[i] == '{' || s[i] == '['){
                c.Push(s[i]);
            }
            else if(s[i] == ']' ){
                if(c.Count >0 && c.Peek() == '['){
                c.Pop();
                }
                else{
                    return false;
                }
            }
            else if(s[i] == '}'){
                if(c.Count >0 && c.Peek() == '{'){
                c.Pop();
                }
                else{
                    return false;
                }
            }
            else if(s[i] == ')'){
                if(c.Count >0 && c.Peek() == '('){
                c.Pop();
                }
                else{
                    return false;
                }
            }
        }
        if(c.Count == 0){
            return true;
        }
        return false;
    }
}