//https://leetcode.com/problems/unique-binary-search-trees-ii/description/
//Given an integer n, return all the structurally unique BST's (binary search trees),
//which has exactly n nodes of unique values from 1 to n.
//Return the answer in any order.

namespace LeetCode;

public class UniqueBSTGenerator
{
    public static List<TreeNode?> GenerateTrees(int startNode, int endNode)
    {
        var trees = new List<TreeNode?>();
        if (startNode > endNode)
        {
            trees.Add(null);
            return trees;
        }

        for (int i = startNode; i <= endNode; ++i)
        {
            //Generate subtrees
            List<TreeNode?> leftTrees = GenerateTrees(startNode, i - 1);
            List<TreeNode?> rightTrees = GenerateTrees(i + 1, endNode);
            //Connect subtrees with root node
            foreach (var leftTree in leftTrees)
            {
                foreach (var rightTree in rightTrees)
                {
                    TreeNode curRoot = new TreeNode(i);
                    curRoot.left = leftTree;
                    curRoot.right = rightTree;
                    trees.Add(curRoot);
                }
            }
        }

        return trees;
    }

    public static List<TreeNode?> GenerateTrees(int nodesCount)
    {
        if (nodesCount == 0)
        {
            return new List<TreeNode?>();
        }

        return GenerateTrees(1, nodesCount);
    }
}