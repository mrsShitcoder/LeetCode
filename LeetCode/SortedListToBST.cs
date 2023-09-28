//https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
//Given the head of a singly linked list where elements are sorted in ascending order,
//convert it to a height-balanced binary search tree.

namespace LeetCode;
//LeetCode uses old C# version
#nullable disable

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class SortedListToBST
{
    //Slow-fast pointer solution
    public TreeNode Convert(ListNode head)
    {
        if (head is null)
        {
            return null;
        }

        if (head.next is null)
        {
            return new TreeNode(head.val);
        }

        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = null;

        while ((fast != null) && (fast.next != null))
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        TreeNode root = new TreeNode(slow.val);
        prev.next = null;
        root.left = Convert(head);
        root.right = Convert(slow.next);
        return root;
    }
    
    public static void LevelOrderPrintTree(TreeNode root)
    {
        if (root is null)
        {
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            TreeNode first = queue.Dequeue();
            Console.Write("{0} ", first.val);
            
            if (first.left is not null)
            {
                queue.Enqueue(first.left);
            }

            if (first.right is not null)
            {
                queue.Enqueue(first.right);
            }
        }
        Console.WriteLine();
    }
}
