// https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
using System;
using System.Linq;

class Solution
{
    public static int BinarySearchRanking(int[] inputArray, int keySearch, int minIndex, int maxIndex)
    {
        var midIndex = 0;

        while (minIndex <= maxIndex)
        {
            midIndex = (minIndex + maxIndex) / 2;

            if (keySearch == inputArray[midIndex]) return ++midIndex;
            else if (keySearch >= inputArray[midIndex]) maxIndex = midIndex - 1;
            else minIndex = midIndex + 1;
        }

        if (keySearch <= inputArray[midIndex]) return midIndex + 2;
        if (keySearch > inputArray[midIndex]) return midIndex + 1;

        return midIndex;
    }

    static void Main()
    {
        var n1                    = Console.ReadLine();
        string scores_temp_string = Console.ReadLine();
        string[] scores_temp      = scores_temp_string.Split(' ');
        string[] scores_temp2     = scores_temp.Distinct().ToArray();
        int[] scores              = Array.ConvertAll(scores_temp2, Int32.Parse);
        int n                     = scores.Length;
        int m                     = Convert.ToInt32(Console.ReadLine());
        string[] alice_temp       = Console.ReadLine().Split(' ');
        int[] alice               = Array.ConvertAll(alice_temp, Int32.Parse);

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(BinarySearchRanking(scores,alice[i],0,n-1));
        }
    }
}