// https://www.hackerrank.com/challenges/mars-exploration/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        int altered = 0;
        for(int i = 0; i < S.Length; i++){
            if((i%3 == 0 || i%3 == 2) && S[i] != 'S'){altered++;}
            if(i%3 == 1 && S[i] != 'O'){altered++;}
        }
        Console.WriteLine(altered);
    }
}