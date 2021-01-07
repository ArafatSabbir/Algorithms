// Runtime: 88 ms, faster than 90.91% of C# online submissions for Number of Students Doing Homework at a Given Time.
// Memory Usage: 25.3 MB, less than 69.42% of C# online submissions for Number of Students Doing Homework at a Given Time.



public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        var len = startTime.Length;
        var count = 0; 
        for(var i = 0; i<len; i++)
        {
            if(startTime[i]<= queryTime && endTime[i]>=queryTime)
                count += 1;
        }
        
        return count;
        
    }
}
