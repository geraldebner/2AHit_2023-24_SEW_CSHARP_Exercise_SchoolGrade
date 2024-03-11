﻿using System;
using System.Diagnostics;

namespace School;

public class SchoolGradeApp
{
    
    public static void Main()
    {
        Student amir = new Student("Amir","jafari",9,2006);

        Grade english = new Grade(1, "english");
        Grade german = new Grade(4, "german");
        
        amir.AddGrade(english);
        amir.AddGrade(german);
        amir.AddGrade(2, "math");
        amir.AddGrade(new Grade( 4, "chemistry"));

        List<Grade> grades = amir.SortGradeBySubject();

        foreach(Grade grade in grades){
            Console.WriteLine(grade.Subject + ": " + grade.Grading);
        }
        
    }
}