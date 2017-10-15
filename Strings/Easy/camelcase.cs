// https://www.hackerrank.com/challenges/camelcase/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int words = 1;
        for(int i = 0; i < s.Length; i++){
            if(!char.IsLower(s[i])){
                words++;
            }
        }
        Console.WriteLine(words);
    }
}