// https://www.hackerrank.com/challenges/extra-long-factorials/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution {
    static BigInteger factorial(int n){
        BigInteger rtnVal;
        if(n == 1){
            return 1;
        }
        
        rtnVal = factorial(n - 1) * n;
        return rtnVal;
    }
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(factorial(n));
    }
}