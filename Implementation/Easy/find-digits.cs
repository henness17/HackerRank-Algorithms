// https://www.hackerrank.com/challenges/find-digits/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int divisible = 0;
            string myString = n.ToString();
            for(int i = 0; i < myString.Length; i++){
                int digit = Int32.Parse(myString[i].ToString());
                if(digit > 0){
                    if(n%digit == 0){
                        divisible++;
                    }   
                }
            }
            Console.WriteLine(divisible);
        }
    }
}