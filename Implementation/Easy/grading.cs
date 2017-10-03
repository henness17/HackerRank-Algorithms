// https://www.hackerrank.com/challenges/grading/submissions/code/45628110
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static int[] solve(int[] grades){
        // Complete this function
        int size = grades.Length;
        int[] curved = new int[size];
        for(int i = 0; i < size; i++){
            int inputGrade = 0;
            if(grades[i] < 38){
                inputGrade = grades[i];
            }else if(((grades[i]+1)%5) == 0){
                inputGrade = grades[i]+1;
            }else if((grades[i]+2)%5 == 0){
                inputGrade = grades[i]+2;
            }
            else{
                inputGrade = grades[i];
            }
            curved[i] = inputGrade;
        }
        return curved;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
        

    }
}