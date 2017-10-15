// https://www.hackerrank.com/challenges/flatland-space-stations/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]); // cities
        int m = Convert.ToInt32(tokens_n[1]); // stations
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        int longestPath = 0;
        int frontPath;
        int endPath;
        bool baseCase = false;
        Array.Sort(c); 
        if(n == m){
            Console.WriteLine(0);
            baseCase = true;
        }
        if(!baseCase){
            frontPath = c[0];
            endPath = n - 1 - c[c.Length - 1];
            for(int i = 1; i < c.Length; i++){
                if(c[i] - c[i-1] > longestPath){
                    longestPath = c[i] - c[i-1];
                }
            }
            int returnValue;
            int longestOutter;
            if(frontPath > endPath)
            {
                longestOutter = frontPath;
            }else{
                longestOutter = endPath;
            }
            if(longestOutter > longestPath/2){
                returnValue = longestOutter;
            }else{
                if(longestPath%2==0){
                    returnValue = longestPath/2;
                }else{
                    returnValue = (longestPath)/2;
                }
            }
            Console.WriteLine(returnValue);
        }
    }
}