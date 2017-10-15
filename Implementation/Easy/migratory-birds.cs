// https://www.hackerrank.com/challenges/migratory-birds/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] types_temp = Console.ReadLine().Split(' ');
        int[] types = Array.ConvertAll(types_temp,Int32.Parse);
        // your code goes here
        int[] typesCount = new int[5] {0, 0, 0, 0, 0};
        for(int i = 0; i < n; i++){
            typesCount[types[i] - 1]++;
        }
        int maxIndex = 0;
        int maxValue = 0;
        for(int i = 0; i < 5; i++){
            if(typesCount[i] > maxValue){
                maxValue = typesCount[i];
                maxIndex = i;
            }
        }
        int most = maxIndex + 1;
        Console.WriteLine(most);
    }
}