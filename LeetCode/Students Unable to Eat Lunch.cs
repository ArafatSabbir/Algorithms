public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) 
    {
        int index = 0;
        Queue<int> q = new Queue<int>();

        foreach(var s in students)
        {
            q.Enqueue(s);
        }

        while(q.Count > 0 && index < sandwiches.Length)
        {
            int count = q.Count;
            bool isAnyMatch = false;

            for(int i = 0; i < count; i++)
            {
                int next = q.Dequeue();

                if(next == sandwiches[index])
                {
                    isAnyMatch = true;
                    index++;
                }

                else                
                {
                    q.Enqueue(next);    
                }            
            }

            if(!isAnyMatch)
            {
                break;
            }
        }

        return q.Count;
    }
}
