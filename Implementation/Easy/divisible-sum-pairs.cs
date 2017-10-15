// https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        // write your code here
        // n - size or array
        // i < j - positions
        // a[i] + a[j] divisible by k
        // print number of i,j pairs that satisfy
        int passingPairs = 0;
        for(int i = 0; i < n - 1; i++){
            for(int j = i + 1; j < n; j++){
                if((a[i] + a[j])%k == 0){
                    passingPairs++;
                }
            }
        }
        Console.WriteLine(passingPairs);
    }
}