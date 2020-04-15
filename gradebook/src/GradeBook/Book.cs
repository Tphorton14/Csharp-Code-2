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
    List<double> grades;
    Static private string name;
    }

}