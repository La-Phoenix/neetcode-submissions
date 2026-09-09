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
    // Using a recursive preorder i.e (NLR) DFS
    public int GoodNodes(TreeNode root) {
        return GoodNode(root);
    }

    public int GoodNode(TreeNode node, int max = int.MinValue){
        int count = 0;
        if (node is null) return count;
        if (node.val >= max) {
            count = 1;
            max = node.val;
        }
        count += GoodNode(node.left, max);
        count += GoodNode(node.right, max);
        return count;
    }
}
