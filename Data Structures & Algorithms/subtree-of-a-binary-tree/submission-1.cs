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
    // Using iterative DFS to traverse tree while using recursive DFS to verify subtree validity
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root is null || subRoot is null) return root == subRoot;
        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0){
            TreeNode node = stack.Pop();
            if(IsSameTree(node, subRoot)){
                return true;
            }
            if (node.left is not null){
                stack.Push(node.left);
            }
            if (node.right is not null){
                stack.Push(node.right);
            }
        }

        return false;
    }

    public bool IsSameTree(TreeNode p, TreeNode q){
        if (p is null || q is null) return p == q;
        if(p.val != q.val){
            return false;
        }
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
