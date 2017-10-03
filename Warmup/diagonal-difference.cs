// https://www.hackerrank.com/challenges/diagonal-difference/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int firstSum = 0;
        int secondSum = 0;
        for(int i = 0; i < n; i++){
            firstSum = firstSum + a[i][i];
            secondSum = secondSum + a[i][n - 1 - i];
        }
        int rtnVal = Math.Abs(firstSum - secondSum);
        Console.WriteLine(rtnVal);
    }
}