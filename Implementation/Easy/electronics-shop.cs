// https://www.hackerrank.com/challenges/electronics-shop/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getMoneySpent(int[] keyboards, int[] drives, int s){
        // Complete this function, she wants to spend as much money as she can
        Array.Sort(keyboards);
        Array.Sort(drives);
        if(keyboards[0] + drives[0] > s){
            return -1;
        }
        if(keyboards[0] + drives[0] == s){
            return s;
        }
        int diff = Int32.MaxValue;
        int l = 0;
        int r = drives.Length - 1;
        int result = -1;
        while((l < keyboards.Length) && (r >= 0)){
            if(Math.Abs(keyboards[l] + drives[r] - s) < diff && s - (keyboards[l] + drives[r]) >= 0){
                diff = Math.Abs(keyboards[l] + drives[r] - s);
                result = keyboards[l] + drives[r];
            }else if(keyboards[l] + drives[r] < s){
                l++;
            }else{
                r--;
            }
        }
        return result;
    }

    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]); // money to spend
        int n = Convert.ToInt32(tokens_s[1]); // keyboard count
        int m = Convert.ToInt32(tokens_s[2]); // usb count 
        string[] keyboards_temp = Console.ReadLine().Split(' ');
        int[] keyboards = Array.ConvertAll(keyboards_temp,Int32.Parse); // price of each
        string[] drives_temp = Console.ReadLine().Split(' ');
        int[] drives = Array.ConvertAll(drives_temp,Int32.Parse);
        //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
        int moneySpent = getMoneySpent(keyboards, drives, s);
        Console.WriteLine(moneySpent);
    }
}