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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p is null && q is null) return true;
        if (p is null && q is not null) return false;
        if (p is not null && q is null) return false;

        bool isEqual = true;
        if (p.val == q.val) {
            isEqual = IsSameTree(p.left, q.left);
            if (isEqual){
                isEqual = IsSameTree(p.right, q.right);
            }
        } else {
            isEqual = false;
        }
        return isEqual;
    }
}
