// https://www.hackerrank.com/challenges/mini-max-sum/submissions/code/45605732
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        Array.Sort(arr);
        long min = 0;
        long max = 0;
        for(int i = 0; i < 4; i++){
           min = min + arr[i];
        }
        for(int i = 4; i > 0; i--){
            max = max + arr[i];
        }
        Console.WriteLine(min + " " + max);
    }
}