﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 10110 }
            };

            var groupedResult = from s in studentList
                                group s by s.Age;
            var lookupResult = studentList.ToLookup(s => s.Age);

           

        }
    }

    internal class Student
    {
        public int StudentID { get; internal set; }
        public string StudentName { get; internal set; }
        public int Age { get; internal set; }
    }
}
