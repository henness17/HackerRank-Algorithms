// https://www.hackerrank.com/challenges/picking-numbers/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int[] bucket = new int[100];
        if(a.Length == 0){Console.WriteLine(0);} 
        for(int i = 0; i < a.Length; i++){
            bucket[a[i]]++;
        }
        int max = 0;
        for(int i = 1; i < bucket.Length; i++){
            if(bucket[i] + bucket[i - 1] > max){
                max = bucket[i] + bucket[i - 1];
            }
        }
        Console.WriteLine(max);
    }
}