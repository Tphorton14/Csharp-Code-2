﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{

    class Program
    {
        // method
        // when dotnet runs it looks for "Main"
        static void Main(string[] args)
        {
            var book = new Book("My Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStats();
            

            var grades = new List<double>() { 12.7, 14.5, 15.8 , 4.1};
            grades.Add(56.1);

            // how to loop through array and sum all numbers in array
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            // looping through collection of numbers
            foreach(var number in grades) {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                // adding numbers to result
               result += number;
            }
            // dividing by Count
            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}!");
        }

    }
}

