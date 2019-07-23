using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingChar
{
    class Solution
    {
        static void Main(string[] args)
        {
            var s = "abcabcbb";
            if (args.Length > 0)
            {
                s = args[0];
            }

            var soln = new Solution();
            System.Console.WriteLine($"{s}: {soln.LengthOfLongestSubstring(s)}");
        }

        public int LengthOfLongestSubstring(string s)
        {
            var maxLen = 0;
            var currentSet = new HashSet<char>();
            int start = 0, end = 0;
            var len = s.Length;
            var count = 0;
            while (start < len && end < len && start <= end)
            {
                if (currentSet.Contains(s[end]))
                {
                    currentSet.Remove(s[start]);
                    start++;
                    count--;
                }
                else
                {
                    currentSet.Add(s[end]);
                    end++;
                    count++;
                }
                maxLen = Math.Max(count, maxLen);
            }
            return maxLen;
        }
    }
}
