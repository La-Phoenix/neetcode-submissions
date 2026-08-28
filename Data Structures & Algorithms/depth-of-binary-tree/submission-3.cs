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
    public int MaxDepth(TreeNode root) {
        if (root is null) return 0;
        // Using Iteration DFS - Stack
        Queue<(TreeNode Node, int Depth)> queue = new();
        queue.Enqueue((root, 1));
        int maxDepth = 0;

        while (queue.Any()){
            var top = queue.Dequeue();
            if (top.Node.left is null && top.Node.right is null) {
                maxDepth = Math.Max(maxDepth, top.Depth);
            }
            if (top.Node.left is not null){
                queue.Enqueue((top.Node.left, top.Depth + 1));
            }
            if (top.Node.right is not null){
                queue.Enqueue((top.Node.right, top.Depth + 1));
            }
        }

        return maxDepth;
    }
}