// https://www.hackerrank.com/challenges/staircase/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int hashCount = 1;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n - hashCount; j++){
                Console.Write(" ");
            }
            for(int j = 0; j < hashCount - 1; j++){
                Console.Write("#");
            }
            Console.Write("#\n");
            hashCount++;
        }
    }
}