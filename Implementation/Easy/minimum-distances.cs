// https://www.hackerrank.com/challenges/minimum-distances/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A_temp = Console.ReadLine().Split(' ');
        int[] A = Array.ConvertAll(A_temp,Int32.Parse);
        int minDistance = -1;
        Dictionary<int, int> hashmap = new Dictionary<int, int>();
        for(int i = 0; i < A.Length; i++){
            int distance;
            if(hashmap.ContainsKey(A[i])){
                distance = i - hashmap[A[i]]; 
                if((distance < minDistance) || minDistance == -1){
                    minDistance = distance;
                    hashmap[A[i]] = i;
                }
            }else{
                hashmap.Add(A[i], i);
            }
            
        }
        Console.WriteLine(minDistance);
    }
}