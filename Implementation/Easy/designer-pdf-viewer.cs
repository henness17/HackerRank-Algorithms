// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp,Int32.Parse);
        string word = Console.ReadLine();
        int highestLetter = 0;
        for(int i = 0; i < word.Length; i++){
         if(highestLetter < h[char.ToUpper(word[i]) - 65]){
             highestLetter = h[char.ToUpper(word[i]) - 65];
         }   
        }
        Console.WriteLine(word.Length * highestLetter);
    }
}