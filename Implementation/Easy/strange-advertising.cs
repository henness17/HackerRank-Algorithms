// https://www.hackerrank.com/challenges/strange-advertising/problem
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_s[0]);
        int people = 5;
        int liked = 0;
        for(int i = 0; i < n; i++){
            liked += (people/2);
            people = (people/2)*3;
        }
        Console.WriteLine(liked);
    }
}