using System;
using System.Collections.Generic;

namespace GradeBook {

class Book {

    public Book(string name) {
        grades = new List<double>();
        this.name = name;
    }

    public void AddGrade(double grade) {
        grades.Add(grade);
    }
    public void ShowStats()
        {
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
    List<double> grades;
    private string name;

        
    }

}