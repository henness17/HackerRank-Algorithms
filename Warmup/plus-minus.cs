// https://www.hackerrank.com/challenges/plus-minus/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        double positive = 0;
        double negative = 0;
        double zero = 0;
        for(int i = 0; i < n; i++){
            if(arr[i] == 0){
                zero++;
            }else if(arr[i] > 0){
                positive++;
            }else{
                negative++;
            }
        }
        Console.WriteLine(positive/n);
        Console.WriteLine(negative/n);
        Console.WriteLine(zero/n);
    }
}