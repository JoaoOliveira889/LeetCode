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
    private Dictionary<string, int> subTreeCount;
    private Dictionary<int, int> idsCount;
    private int nextId;
    private IList<TreeNode> result;

    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
       
        subTreeCount = new();
        idsCount = new();
        nextId = 1;
        result = new List<TreeNode>();

        DFS(root);

        return result;
    }

    private int DFS(TreeNode node)
    {
        if(node is null) return 0;

        int leftId = DFS(node.left);
        int rightId = DFS(node.right);

        string signature = $"{node.val},{leftId},{rightId}";

       if(subTreeCount.ContainsKey(signature)){
        int currentId = subTreeCount[signature];
        idsCount[currentId]++;

        if(idsCount[currentId] == 2)
            result.Add(node);

        return currentId;
       }else{
        int newId = nextId++;
        subTreeCount[signature] = newId;
        idsCount[newId] = 1;
        
        return newId;
       }
    }
}