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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        StringBuilder sb = new();
        BuildString(sb, root);
        return sb.ToString();
    }
    public void BuildString(StringBuilder sb, TreeNode node){
        if (node is null) {
            sb.Append("#");
            sb.Append(",");
            return;
        };
        sb.Append(node.val.ToString());
        sb.Append(",");
        BuildString(sb, node.left);
        BuildString(sb, node.right);
        return;
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        string[] arr = data.Split(",");
        TreeNode BuildTree(ref int ind){
            if (arr[ind] == "#") {
                ind ++;
                return null;
            };
            TreeNode node = new TreeNode(int.Parse(arr[ind]));
            ind++;
            node.left = BuildTree(ref ind);
            node.right = BuildTree(ref ind);
            return node;
        }
        int startInd = 0;
        return BuildTree(ref startInd);
    }

}
