// https://www.hackerrank.com/challenges/between-two-sets/submissions/code/45630617
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int between = 0;
        for(int i = a[n - 1]; i <= b[0]; i++){
            bool passes = true;
            for(int j = 0; j < n; j++){
                if(i%a[j] != 0){
                    passes = false;
                }
            }
            if(passes == true){
                 for(int j = 0; j < m; j++){
                    if(b[j]%i != 0){
                       passes = false;
                    }
                } 
            }
            if(passes){
                between++;
            }
        }
        Console.WriteLine(between);
    }
}