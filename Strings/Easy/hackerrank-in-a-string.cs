// https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            // your code goes here
            string hackerrank = "hackerrank";
            int hr = 0;
            for(int i = 0; i < s.Length && hr < hackerrank.Length; i++){
                if(s[i] == hackerrank[hr]){
                    hr++;
                }
            }
            if(hr == hackerrank.Length){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}