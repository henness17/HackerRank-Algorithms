// https://www.hackerrank.com/challenges/apple-and-orange/submissions/code/45629221
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp,Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp,Int32.Parse);
        // s, t - left and right of house
        // a, b - apple and orange trees
        // m - number of apples
        // n - number of oranges
        // apple - how far each apple fell
        // orange - how far each orange fell
        int hittingApples = 0;
        int hittingOranges = 0;
        for(int i = 0; i < m; i++){
            if(((a + apple[i]) >= s) && ((a + apple[i]) <= t)){
                hittingApples++;
            }
        }
        for(int i = 0; i < n; i++){
            if(((b + orange[i]) <= t) && ((b + orange[i]) >= s)){
                hittingOranges++;
            }
        }
        Console.WriteLine(hittingApples);
        Console.WriteLine(hittingOranges);
    }
}