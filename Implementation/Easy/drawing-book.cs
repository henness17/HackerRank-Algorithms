// https://www.hackerrank.com/challenges/drawing-book/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int p){
        // n = pages
        // p = page number
        if(p < (n-p) || p == (n-p)){
            // start from front
            int currentPage = 1;
            int flipCount = 0;
            if(currentPage != p){
                flipCount++;
                currentPage++;
            }
            while((currentPage != p) && (currentPage+1 != p)){
                flipCount++;
                currentPage += 2;
            }
            return flipCount;
        }else{
            // start from back
            int currentPage = n;
            int flipCount = 0;
            if(currentPage%2==0){
                if(currentPage == p){
                    return flipCount;
                }
                flipCount++;
                currentPage--;
                if((currentPage == p) || (currentPage - 1) == p){
                    return flipCount;
                }
            }
            while((currentPage != p) && (currentPage - 1) != p){
                flipCount++;
                currentPage -= 2;
            }
            return flipCount;
        }
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);

    }
}
