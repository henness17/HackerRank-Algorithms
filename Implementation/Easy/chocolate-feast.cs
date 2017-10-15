// https://www.hackerrank.com/challenges/chocolate-feast/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]); // dollars
            int c = Convert.ToInt32(tokens_n[1]); // cost
            int m = Convert.ToInt32(tokens_n[2]); // turn in wrappers
            int chocolates = n/c;
            n = 0;
            int wrappers = chocolates;
            while(wrappers >= m){
                wrappers = wrappers - m;
                wrappers++;
                chocolates++;
            }
            Console.WriteLine(chocolates);
        }
    }
}