// https://www.hackerrank.com/challenges/repeated-string/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());
        // Count a's in 1 string
        long asInWord = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'a'){asInWord++;}
        }
        long knownStrings = n/s.Length;
        long finalCount = knownStrings * asInWord;
        long charactersLeft = (n - (knownStrings*s.Length));
        for(int i = 0; i < charactersLeft; i++){
            if(s[i] == 'a'){finalCount++;}
        }
        Console.WriteLine(finalCount);
    }
}