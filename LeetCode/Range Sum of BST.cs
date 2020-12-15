// Runtime: 188 ms, faster than 24.48% of C# online submissions for Range Sum of BST.
// Memory Usage: 45.2 MB, less than 43.58% of C# online submissions for Range Sum of BST.



/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int RangeSumBST(TreeNode root, int L, int R) {
        if(root == null)
            return 0;
        if(root.val < L)
            return RangeSumBST(root.right,L,R);
        if(root.val > R)
            return RangeSumBST(root.left,L,R);
        
        return root.val + RangeSumBST(root.right,L,R) + RangeSumBST(root.left,L,R);
    }
}
