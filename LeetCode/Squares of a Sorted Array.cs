// Runtime: 296 ms, faster than 56.92% of C# online submissions for Squares of a Sorted Array.
// Memory Usage: 40.4 MB, less than 91.26% of C# online submissions for Squares of a Sorted Array.




public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(var i = 0; i < nums.Length; i++) {
            nums[i] = nums[i] * nums[i];
        }
        
        Array.Sort(nums);
        return nums;
    }
}
