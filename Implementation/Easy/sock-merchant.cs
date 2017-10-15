// https://www.hackerrank.com/challenges/sock-merchant/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        int[] colors = new int[101];
        for(int i = 0; i < n; i++){
            colors[c[i]]++;
        }
        int matches = 0;
        for(int i = 0; i < 101; i++){
            matches += (colors[i]/2);
        }
        Console.WriteLine(matches);
    }
}