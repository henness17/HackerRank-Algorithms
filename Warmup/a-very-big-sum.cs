// https://www.hackerrank.com/challenges/a-very-big-sum/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        long sum = 0;
        for(int i = 0; i < n; i++){
            sum = arr[i] + sum;
        }
        Console.WriteLine(sum);
    }
}
