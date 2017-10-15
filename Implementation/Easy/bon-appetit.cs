// https://www.hackerrank.com/challenges/bon-appetit/problem
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        // n = array size
        // k = index of item he might have forgot
        // line three = price array
        // line 3 = amount Brian charged Anna
        string[] tokens_s = Console.ReadLine().Split(' ');
        int arraySize = Convert.ToInt32(tokens_s[0]);
        int itemIndex = Convert.ToInt32(tokens_s[1]);
        string[] items_temp = Console.ReadLine().Split(' ');
        int[] intItems = Array.ConvertAll(items_temp,Int32.Parse);
        double[] items = new double[intItems.Length];
        for(int i = 0; i < intItems.Length; i++){
            items[i] = intItems[i];
        }
        int chargedAnna = Convert.ToInt32(Console.ReadLine());
        double correctCost = 0;
        double incorrectCost = 0;
        for(int i = 0; i < arraySize; i++){
            if(i == itemIndex){
                incorrectCost += ((items[i])/2);
            }else{
                incorrectCost += (items[i]/2);
                correctCost += (items[i]/2);
            }
        }
        if(chargedAnna == correctCost){
            Console.WriteLine("Bon Appetit");
        }else{
            Console.WriteLine(incorrectCost-correctCost);
        }
    }
}