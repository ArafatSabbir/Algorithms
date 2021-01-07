// Runtime: 304 ms, faster than 70.51% of C# online submissions for Arithmetic Subarrays.
// Memory Usage: 33.2 MB, less than 58.97% of C# online submissions for Arithmetic Subarrays.

public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var ans = new List<bool>();
        for (var i = 0; i < l.Length; i++)
        {
            var arr = new int[r[i] - l[i] + 1];
            Array.Copy(nums, l[i], arr, 0, r[i] - l[i] + 1);
            Array.Sort(arr);
            ans.Add(IfArithmetic(arr));
        }

        return ans;
    }

    public static bool IfArithmetic(int[] arr)
    {
        if (arr.Length <= 1)
            return false;

        var diff = arr[1] - arr[0];
        for (var i = 2; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] != diff)
            {
                return false;
            }
        }

        return true;
    }
}
