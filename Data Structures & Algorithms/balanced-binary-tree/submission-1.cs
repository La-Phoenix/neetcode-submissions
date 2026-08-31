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
    // Using Recursion
    public bool IsBalanced(TreeNode root) {
        return MaxDepth(root).IsBalanced;
    }

    public (int Depth, bool IsBalanced) MaxDepth(TreeNode node, bool isBalanced = true) {
        if (node == null || !isBalanced) return (0, isBalanced);
        var left = MaxDepth(node.left);
        var right = MaxDepth(node.right);
        if (!left.IsBalanced || !right.IsBalanced) {
            return (1 + Math.Max(left.Depth, right.Depth), false);
        }
        if (Math.Abs(right.Depth - left.Depth) > 1){
            isBalanced = false;
        }
        return (1 + Math.Max(left.Depth, right.Depth), isBalanced);
    }
}
