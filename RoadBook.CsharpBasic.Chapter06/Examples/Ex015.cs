using System;
using System.Collections.Generic;
using System.Text;
using RoadBook.CsharpBasic.Chapter06.Examples.Model;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex015
    {
        public void Run()
        {
            //ArrayList arrStudent = new ArrayList(); > 출력할 때 (Student)를 붙여서 언박싱 해야됨
            List<Student> arrStudent = new List<Student>();

            Student student = new Student();
            student.Id = "S001";
            student.Name = "홍길동";
            student.Department = "국어국문학과";
            student.Grade = 1;
            student.Age = 21;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                Console.WriteLine(arrStudent[idx].Id);
                Console.WriteLine(arrStudent[idx].Name);
                Console.WriteLine(arrStudent[idx].Department);
                Console.WriteLine(arrStudent[idx].Grade);
                Console.WriteLine(arrStudent[idx].Age);
            }
        }
    }
}
