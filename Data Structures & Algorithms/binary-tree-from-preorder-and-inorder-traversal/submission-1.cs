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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int n = inorder.Length;
        Dictionary<int, int> inorderHash = new();
        for (int i = 0; i < n; i++) {
            inorderHash[inorder[i]] = i;
        }
        
        TreeNode BuildTree(
        int preorderStart, 
        int preorderEnd, 
        int inorderStart,
        int inorderEnd
        )
        {
            if (preorderStart > preorderEnd || inorderStart > inorderEnd) return null;
            TreeNode root = new TreeNode(preorder[preorderStart]);
            int rootInd = inorderHash[root.val];
            int leftInorderSize = rootInd - inorderStart;
            
            root.left = BuildTree(
                preorderStart + 1,
                preorderStart + leftInorderSize,
                inorderStart,
                rootInd - 1
            );
            root.right = BuildTree(
                preorderStart + leftInorderSize + 1,
                preorderEnd,
                rootInd + 1,
                inorderEnd
            );
            return root;
        }

        return BuildTree(0, n - 1, 0, n - 1);
    }
}
