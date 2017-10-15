// https://www.hackerrank.com/challenges/utopian-tree/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int c = n; // counter
            int e = 0; // keep track of the even values of n
            int o = 0; // keep track of the odd values of n
            while(c >= 0){
                // use % to check whether c is even or odd
                if(c%2 == 0){
                    // all even numbers of n are equal to the last even number times 2, plus 1
                    e = (e * 2) + 1; 
                }else{
                    // all odd numbers of n are equal to the last od number times 2, plus 2
                    o = (o * 2) + 2;
                }
                c--;
            }
            // depending whether n was even or odd, print e or o
            if(n%2 == 0){
                Console.WriteLine(e);
            }else{
                Console.WriteLine(o);
            }
        }
    }
}