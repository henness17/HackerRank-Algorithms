// https://www.hackerrank.com/challenges/the-hurdle-race/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]); // hurdles
        int k = Convert.ToInt32(tokens_n[1]); // initial jump
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp,Int32.Parse);
        // your code goes here
        int currentJump = k;
        int drinksConsumed = 0;
        for(int i = 0; i < n; i++){
            while(currentJump < height[i]){
                drinksConsumed++;
                currentJump++;
            }
        }
        Console.WriteLine(drinksConsumed);
    }
}