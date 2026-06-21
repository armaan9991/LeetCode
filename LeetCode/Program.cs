using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Contains_Duplicate_217 solution = new Contains_Duplicate_217();

        int[] nums = { 1, 2, 3, 1 };
        int[] nums2 = { 1, 2, 3, 4 };
        int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        Console.WriteLine(solution.contain_Duplicate(nums));
        Console.WriteLine(solution.contain_Duplicate(nums2));
        Console.WriteLine(solution.contain_Duplicate(nums3));

    }
}