using System;
using System.Collections.Generic;
using System.Text;

// resources
// https://afsdzvcx123.tistory.com/entry/C-%EB%AC%B8%EB%B2%95-C-LINQ-Take-TakeWhile-%EB%A9%94%EC%84%9C%EB%93%9C?category=784688

namespace LearningCSharp.Explore
{
    class TestLINQ
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            InitializeStudents(students);

            foreach (var student in students)
            {
                Console.WriteLine($"name : {student.Name}  age : {student.Age}  grade : {student.Grade}");
            }
        }

        public static void InitializeStudents(List<Student> students)
        {
            students.Add(new Student() { Name = "Tom", Age = 20, Grade = "A" });
            students.Add(new Student() { Name = "Bob", Age = 30, Grade = "D" });
            students.Add(new Student() { Name = "Lonnie", Age = 44, Grade = "A" });
            students.Add(new Student() { Name = "John", Age = 12, Grade = "C" });
            students.Add(new Student() { Name = "Julia", Age = 90, Grade = "B" });
            students.Add(new Student() { Name = "Stephanie", Age = 33, Grade = "C" });
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }
        }
    }
}