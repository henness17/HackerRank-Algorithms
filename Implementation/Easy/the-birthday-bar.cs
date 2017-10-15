// https://www.hackerrank.com/challenges/the-birthday-bar/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int[] s, int d, int m){
        // Complete this function
        // n - size of array
        // s - array
        // d  - value to sum to 4
        // m - squares (array positions) 1
        int cutsFound = 0;
        for(int i = 0; i < (n - m + 1); i++){
            int currentCutValue = 0;
            for(int j = i; j < (i + m); j++){
                currentCutValue += s[j];
            }
            if(currentCutValue == d){
                cutsFound++;
            }
        }
        return cutsFound;      
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
    }
}