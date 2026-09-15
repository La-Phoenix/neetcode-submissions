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
    int res = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        return Math.Max(MaxSum(root), res);
    }

    public int MaxSum(TreeNode node) {
        if (node is null) return 0;

        int left = Math.Max(MaxSum(node.left), 0);
        int right = Math.Max(MaxSum(node.right), 0);

        res = Math.Max(res, (node.val + left + right));
        return node.val + Math.Max(left, right);
    }
}
