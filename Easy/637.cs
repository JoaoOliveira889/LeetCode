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
    public IList<double> AverageOfLevels(TreeNode root) {
        IList<double> result = new List<double>();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while(queue.Count > 0){
            int levelSize = queue.Count;
            double levelSum = 0;

            for(int i =0; i < levelSize; i++){
                TreeNode node = queue.Dequeue();
                levelSum+=node.val;

                if(node.left !=null)
                    queue.Enqueue(node.left);
                if(node.right !=null)
                    queue.Enqueue(node.right);
            }

            result.Add(levelSum/levelSize);
        }

        return result;
    }
}