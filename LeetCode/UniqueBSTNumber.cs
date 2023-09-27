//https://leetcode.com/problems/unique-binary-search-trees/
//Given an integer n, return the number of structurally unique BST's (binary search trees)
//which has exactly n nodes of unique values from 1 to n.
//1 <= n <= 19
namespace LeetCode;

public class UniqueBSTNumber
{
    public static int NumTrees(int n)
    {
        //Number of unique BST with n unique nodes and root i is
        // C[i]*C[n-i-1] where C is Catalan number
        var catalan = new int[n + 1];
        catalan[0] = 1;
        catalan[1] = 1;

        for (int i = 2; i <= n; ++i)
        {
            for (int j = 0; j < i; ++j)
            {
                //using previously computed catalan numbers
                catalan[i] += catalan[j] * catalan[i - j - 1];
            }
        }

        return catalan[n];
    }
}
