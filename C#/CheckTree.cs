//O(1)
//O(1)
public class Solution
{
    public bool CheckTree(TreeNode root)
    {

        if (root == null || root.val == 0) return true;

        return root.left.val + root.right.val == root.val;

    }
}