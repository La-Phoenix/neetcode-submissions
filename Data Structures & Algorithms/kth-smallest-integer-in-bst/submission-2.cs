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
    // Using Recursive Inorder DFS Approach
    public int KthSmallest(TreeNode root, int k) {
        return InorderDFS(root, ref k);
    }

    public int InorderDFS(TreeNode node, ref int count){
        if (node is null) return -1;
        int left = InorderDFS(node.left, ref count);
        if (left != -1) return left;
        count --;
        if (count == 0) return node.val;
        return InorderDFS(node.right, ref count);
    }
}
