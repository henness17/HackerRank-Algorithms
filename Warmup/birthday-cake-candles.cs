// https://www.hackerrank.com/challenges/birthday-cake-candles/submissions/code/45623898
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp,Int32.Parse);
        int tallestCandle = 0;
        int candleCount = 0;
        for(int i = 0; i < height.Length; i++){
            if(height[i] > tallestCandle){
                tallestCandle = height[i];
                candleCount = 1;
            }else if(height[i] == tallestCandle){
                candleCount++;
            }
        }
        Console.WriteLine(candleCount);
    }
}