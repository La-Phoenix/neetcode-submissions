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
    public TreeNode InvertTree(TreeNode root) {
        // Following DFS - Stack is used implicitly
        TreeNode InvertTree(TreeNode curr){
            if (curr is null) return null;
            TreeNode temp = curr.left;
            curr.left = curr.right;
            curr.right = temp;
            
            InvertTree(curr.left);
            InvertTree(curr.right);
            return curr;
        }

        return InvertTree(root);
    }
}
