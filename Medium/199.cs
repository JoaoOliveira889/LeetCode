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
 
//BFS
public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        if (root is null) return [];

        IList<int> result = new List<int>();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int level = queue.Count;
            int rightNode = 0;

            for (int i = 0; i < level; i++)
            {
                TreeNode node = queue.Dequeue();
                rightNode = node.val;

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            result.Add(rightNode);
        }

        return result;
    }
}

//DFS
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        IList<int> result = new List<int>();
        DFS(root, 0, result);
        return result;
    }
    private void DFS(TreeNode node, int currentDepth, IList<int> result) {
        if (node == null) return;
        if (currentDepth == result.Count) result.Add(node.val);

        DFS(node.right, currentDepth + 1, result);
        DFS(node.left, currentDepth + 1, result);
    }
}