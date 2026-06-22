using System.Runtime.CompilerServices;

public class Sum3_15
{
// In this we need to find 3 elements in array whose sum lead to 0
// so we  pick on element from left then we , use 2 pointer approch on elements on its right.
    public List<IList<int>> ThreeSum(int [] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        for(int i=0 ; i< nums.Length - 2; i++)
        {
            if(i>0 && nums[i] == nums[i - 1])       // we skip is element at current iteration is same as last one,means we might be using duplicates now.
            {
                continue;
            }

            int l =i+1;     // start from next
            int r = nums.Length-1;  // last element , right pointer .

            while (l < r)
            {
                int s = nums[i]+nums[l]+nums[r];

                if (s == 0)
                {
                    result.Add(new List<int>{
                        nums[i],
                        nums[l],
                        nums[r]
                });
                // Once we add our triplet to list, then we look for next in remaining list
                l++;
                r--;
                // again check if new values were same as previous then it means we will just get duplicate values just skip them.
                while(l < r && nums[l] == nums[l - 1])
                {
                 l++;   
                }    
                while(l<r && nums[r] == nums[r - 1])
                {
                    r--;
                }
                }
                // if sum was not == 0 
                else
                {
                    // if sum was less than 0 means increment left as we ahve sorted array
                    if (s < 0)
                    {
                        l++;
                    }
                    // else increment right.
                    else
                    {
                        r--;
                    }
                }
            }
        }
        return result;
    }
}