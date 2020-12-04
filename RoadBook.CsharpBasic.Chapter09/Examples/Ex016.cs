﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    class Ex016
    {
        public void Run()
        {
            int cnt;

            List<Model.Student> students = new List<Model.Student>()
            {
                new Model.Student { ID = "S001", Name = "Dexter", Grade = 3, Major = "Softward"},
                new Model.Student { ID = "D001", Name = "Ellin", Grade = 3, Major = "Design"},
                new Model.Student { ID = "S002", Name = "Jeffrey", Grade = 4, Major = "Softward"},
                new Model.Student { ID = "D002", Name = "Sienna", Grade = 4, Major = "Design"},
                new Model.Student { ID = "S003", Name = "Pil", Grade = 4, Major = "Softward"},
                new Model.Student { ID = "S006", Name = "Clinit", Grade = 3, Major = "Softward"},
                new Model.Student { ID = "S004", Name = "Khan", Grade = 2, Major = "Softward"},
                new Model.Student { ID = "A001", Name = "Mike", Grade = 2, Major = "Advertisement"},
                new Model.Student { ID = "S005", Name = "Sven", Grade = 2, Major = "Softward"},
                new Model.Student { ID = "T001", Name = "Peter", Grade = 1, Major = "Theater"},
            };

            Console.WriteLine("학년의 합 : {0}", students.Select(s => s.Grade).Sum());
            Console.WriteLine("최고 학년 : {0}", students.Select(s => s.Grade).Max());
            Console.WriteLine("최저 학년 : {0}", students.Select(s => s.Grade).Min());
            Console.WriteLine("평균 학년 : {0}", students.Select(s => s.Grade).Average());
        }
    }
}