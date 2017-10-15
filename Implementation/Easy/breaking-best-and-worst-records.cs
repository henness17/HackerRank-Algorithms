// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int highChanged = 0; int currentHigh = s[0];
        int lowChanged = 0; int currentLow = s[0];
        for(int i = 0; i < n; i++){
            if(s[i] > currentHigh){
                currentHigh = s[i];
                highChanged++;
            }
            if(s[i] < currentLow){
                currentLow = s[i];
                lowChanged++;
            }
        }
        int[] rtnArr = new int[2];
        rtnArr[0] = highChanged; rtnArr[1] = lowChanged;
        Console.WriteLine(rtnArr[0] + " " + rtnArr[1]);
    }
}