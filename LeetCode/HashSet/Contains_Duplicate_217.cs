public class Contains_Duplicate_217
{
    public bool contain_Duplicate(int[] nums)
    {
        HashSet<int> Val= new HashSet<int>();
        foreach(int num in nums)
        {
        if (Val.Contains(num))
            {
                return true;
            }
        Val.Add(num);
        }
        return false;
    }
 
}
