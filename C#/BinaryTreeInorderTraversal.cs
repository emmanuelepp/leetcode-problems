//O(n)
//O(h)
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null) return new List<int> { };

        var result = new List<int> { };
        TraversalHelper(root, result);

        return result;
    }

    private void TraversalHelper(TreeNode root, List<int> result)
    {
        if (root == null) return;
        TraversalHelper(root.left, result);
        result.Add(root.val);
        TraversalHelper(root.right, result);
    }
}