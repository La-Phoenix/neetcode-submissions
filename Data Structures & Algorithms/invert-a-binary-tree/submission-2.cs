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
        if (root is null) return null;
        // Following DFS - stack
        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0){
            TreeNode curr = stack.Pop();
            TreeNode temp = curr.left;
            curr.left = curr.right;
            curr.right = temp;
            if(curr.left is not null){
                stack.Push(curr.left);
            }
            if(curr.right is not null){
                stack.Push(curr.right);
            }
        }

        return root;
    }
}
