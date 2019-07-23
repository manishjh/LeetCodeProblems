using System;

namespace LeetCode
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    class Solution
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carry = 0;
            var head = new ListNode(0);
            var value = l1.val + l2.val + carry;
            if (value > 9)
            {
                head.val = value % 10;
                carry = value / 10;
            }
            else
            {
                head.val = value;
                carry = 0;
            }
            var lastnode = head;

            l1 = l1?.next;
            l2 = l2?.next;

            while (l1 != null || l2 != null)
            {
                var node = new ListNode(0);
                lastnode.next = node;
                var value1 = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                if (value1 > 9)
                {
                    node.val = value1 % 10;
                    carry = value1 / 10;
                }
                else
                {
                    node.val = value1;
                    carry = 0;
                }
                lastnode = node;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry > 0)
            {
                lastnode.next = new ListNode(carry);
            }

            return head;
        }

        public ListNode CreateListFromNumber(string strNum)
        {
            var head = new ListNode(int.Parse(strNum[strNum.Length - 1].ToString()));
            var lastNode = head;
            for (int i = strNum.Length - 2; i >= 0; i--)
            {
                var node = new ListNode(int.Parse(strNum[i].ToString()));

                lastNode.next = node;

                lastNode = node;
            }

            return head;
        }

        static void Main(string[] args)
        {
            var soln = new Solution();
            var list1 = soln.CreateListFromNumber("180");
            var list2 = soln.CreateListFromNumber("20");
            PrintList(list1);
            PrintList(list2);

            var ans = soln.AddTwoNumbers(list1, list2);
            System.Console.WriteLine("Adding two lists: ");
            PrintList(ans);
        }

        private static void PrintList(ListNode list1)
        {
            var node = list1;
            Console.Write($"{node.val}");
            while (node.next != null)
            {
                node = node.next;
                Console.Write($" -> {node.val}");
            }
            System.Console.WriteLine();
        }
    }
}
