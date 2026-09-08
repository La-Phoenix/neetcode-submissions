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
    // Using Iterative BFS
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new();
        if (root is null) return res;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0){
            int n = queue.Count;
            bool isFirst = true;
            while(n > 0){
                TreeNode node = queue.Dequeue();
                if (isFirst){
                    res.Add(node.val);
                }
                isFirst = false;
                if(node.right is not null){
                    queue.Enqueue(node.right);
                }
                if(node.left is not null){
                    queue.Enqueue(node.left);
                }
                n--;
            }
        }

        return res;
    }
}
