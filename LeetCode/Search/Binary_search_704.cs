public class Binary_search_704 {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0){
            return -1;
        }
        int l =0;
        int r = nums.Length-1;
        while(l<=r){
            int mid = (l+r)/2;
            if(target == nums[mid]){
                return mid;
            }
            else if(target < nums[mid]){
                r = mid-1;
            }
            else{
                l= mid+1;
            }
        }
        return -1;
    }
}