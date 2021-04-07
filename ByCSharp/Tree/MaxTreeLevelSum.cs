using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp.Tree
{
    class MaxTreeLevelSum
    {
        public class Solution
        {
            public int MaxLevelSum(TreeNode root)
            {
                if (root == null)
                    return 0;

                // Initialize result
                int result = root.val;

                // Do Level order traversal keeping
                // track of number of nodes at every
                // level.
                Queue<TreeNode> q = new Queue<TreeNode>();
                q.Enqueue(root);
                while (q.Count != 0)
                {

                    // Get the size of queue when the
                    // level order traversal for one
                    // level finishes
                    int count = q.Count;

                    // Iterate for all the nodes
                    // in the queue currently
                    int sum = 0;
                    while (count-- > 0)
                    {

                        // Dequeue an node from queue
                        TreeNode temp = q.Dequeue();

                        // Add this node's value
                        // to current sum.
                        sum = sum + temp.val;

                        // Enqueue left and right children
                        // of dequeued node
                        if (temp.left != null)
                            q.Enqueue(temp.left);
                        if (temp.right != null)
                            q.Enqueue(temp.right);
                    }

                    // Update the maximum node
                    // count value
                    result = Math.Max(sum, result);
                }
                return result;
            }
        }
    }
}
