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
    public List<List<int>> LevelOrder(TreeNode root) {
        // Using an iterative BFS
        List<List<int>> levels = new();
        if(root is null) return levels;
        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);

        while (queue.Count > 0){
            int n = queue.Count;
            List<int> level = new();
            while(n > 0){
                TreeNode node = queue.Dequeue();
                level.Add(node.val);
                if(node.left is not null) {
                    queue.Enqueue(node.left);
                }
                if (node.right is not null) {
                    queue.Enqueue(node.right);
                }
                n--;
            }
            levels.Add(level);
        }
        return levels;
    }
}
