public class Solution {
    public int rotating_BSearch_33(int[] nums, int target) {
        int l = nums.Length;
        int left=0;
        int right = l-1;
        while(left <= right){
            int mid = (left+right)/2;
            if( nums[mid] == target){
                return mid;
            }
            if(nums[left] <= nums[mid]){
                if(target >= nums[left] && target < nums[mid]){
                    right = mid -1;
                }
                else{
                    left = mid+1;
                }
            }
            else{
                if(target > nums[mid] && target <= nums[right]){
                    left = mid+1;
                }
                else{
                    right = mid -1;
                }
        }
    }
    return -1;
}
}