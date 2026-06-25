public class Daily_temp_739
{
    // Monotonic Stack
    public int[] DailyTemperatures(int[] temp)
    {
        int n = temp.Length;
        int [] answer =  new int[n];
        Stack<int> s = new Stack<int>();
        for(int i = 0; i < n; i++)
        {
           
            while(s.Count>0 && // we keep on calculating diff if we find any day in stack,
                temp[i] > temp[s.Peek()])  // it is only if next day was not hot than prev so only after that it pushed to stack
            {
                int prevD = s.Pop();
                answer[prevD] = i - prevD;        
            }
            
            s.Push(i);
        }
        return answer;
    }
}