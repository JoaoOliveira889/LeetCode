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
    //mapping to get the root posision O(1)
    private Dictionary<int, int> inorderMap = new Dictionary<int, int>();
    private int preorderIndex = 0;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++)
            inorderMap[inorder[i]] = i;
        return Build(preorder, 0, inorder.Length - 1);
    }

    private TreeNode Build(int[] preorder, int inorderStart, int inorderEnd) {
        if (inorderStart > inorderEnd) return null;

        int rootValue = preorder[preorderIndex];
        TreeNode root = new TreeNode(rootValue);
        preorderIndex++;
        
        int rootIndexInorder = inorderMap[rootValue];

        root.left = Build(preorder, inorderStart, rootIndexInorder - 1);
        root.right = Build(preorder, rootIndexInorder + 1, inorderEnd);
        
        return root;
    }
}