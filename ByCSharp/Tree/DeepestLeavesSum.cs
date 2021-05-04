using System;
using System.Collections.Generic;
using System.Text;

namespace ByCSharp.Tree
{
    class DeepestLeavesSum
    {
        public int FinfDeepestLeavesSum(TreeNode root)
        {
            if (root == null)
                return 0;

            int sum = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int count = queue.Count;
                bool isLeaf = true;

                while (count-- > 0)
                {
                    TreeNode node = queue.Dequeue();

                    if (node.left != null || node.right != null)
                        isLeaf = false;
                    else
                        sum += node.val;

                    if (node.left != null)
                        queue.Enqueue(node.left);

                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                if (!isLeaf)
                {
                    sum = 0;
                }
            }
            return sum;
        }
    }
}
