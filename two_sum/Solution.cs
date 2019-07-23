using System.Collections.Generic;

namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //return BruteForce(nums, target);
            var result = HashTableLookup(nums, target);

            watch.Stop();
            System.Console.WriteLine($"time Taken: ticks:{watch.ElapsedTicks} ms:{watch.ElapsedMilliseconds}");
            return result;
        }

        private static int[] BruteForce(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            var one = -1;
            var two = -1;
            return new int[] { one, two };
        }

        private static int[] HashTableLookup(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (var j = 0; j < nums.Length; j++)
            {
                if (map.ContainsKey(target - nums[j]))
                {
                    return new int[] { map[target - nums[j]], j };
                }
                map[nums[j]] = j;
            }
            return new int[] { -1, -1 };
        }

        public static void Main(string[] args)
        {
            var soln = new Solution();
            var arr = new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            var target = 542;
            foreach (var item in soln.TwoSum(arr, target))
            {
                System.Console.WriteLine(item);
            }
        }
    }


}
