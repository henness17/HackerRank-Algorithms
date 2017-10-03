// https://www.hackerrank.com/challenges/compare-the-triplets/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int aScore = 0;
        int bScore = 0;
        for(int i=0; i < 3; i++){
            if((Convert.ToInt32(tokens_a0[i])) > (Convert.ToInt32(tokens_b0[i]))){
                aScore++;
            }
            if((Convert.ToInt32(tokens_a0[i])) < (Convert.ToInt32(tokens_b0[i]))){
                bScore++;
            }
        }
        Console.Write(aScore + " " + bScore);
    }
}