using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// resources
// https://www.tutorialsteacher.com/linq/linq-grouping-operator-groupby-tolookup
namespace LearningCSharp.Explore
{
    class TestLINQ
    {
        static void Main(string[] args)
        {
            List<Student> students = GetDummyStudents();
            // these LINQ extention methods work with array.

            // Use LINQ to find teenager students
            Console.WriteLine("get teenagers");
            List<Student> teenagers = students.Where(s => s.Age >= 12 && s.Age < 20).ToList<Student>();
            teenagers.ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("FirstOrDefault");
            Student bill = students.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.WriteLine(bill);
            Console.WriteLine();

            Console.WriteLine("FirstOrDefault");
            Student numberFive = students.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine(numberFive);
            Console.WriteLine();

            Console.WriteLine("OrderBy");
            students.
                OrderBy(student => student.Age).
                ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("OrderBy");
            students.
                OrderByDescending(student => student.Age).
                ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("OrderBy, ThenBy");
            students.
                OrderBy(student => student.StudentName).
                ThenBy(student => student.Age)
                .ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("OrderBy, ThenBy");
            students.
                OrderBy(student => student.StudentName).
                ThenByDescending(student => student.Age)
                .ToList<Student>().ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            Console.WriteLine("GroupBy");
            var groups = students.GroupBy(student => student.Age);
            foreach (var group in groups)
            {
                Console.WriteLine($"age group: {group.Key}");
                foreach (Student student in group) Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("LookUp");
            var groups2 = students.ToLookup(student => student.Age);
            foreach (var group in groups2)
            {
                Console.WriteLine($"age group: {group.Key}");
                foreach (Student student in group) Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("Select");
            var results = students.Select(student => new { 
                Name = student.StudentName, 
                Age = student.Age 
            });
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();

            Console.WriteLine("All, Any");
            Console.WriteLine(students.All(s => s.Age >= 12 && s.Age < 20));
            Console.WriteLine(students.Any(s => s.Age >= 12 && s.Age < 20));
            Console.WriteLine();

            Console.WriteLine("Contain");
            // it only compares reference of an object
            Console.WriteLine(students.Contains(new Student() { StudentID = 3, StudentName = "Bill", Age = 25 }));
            // in order to compare actual values of an object, need to implement IEqualityComparer.
            Console.WriteLine(students.Contains(new Student() { StudentID = 3, StudentName = "Bill", Age = 25 }, new StudentComparer()));
        }

        class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                if (x.StudentID == y.StudentID &&
                    x.Age == y.Age &&
                    string.Equals(x.StudentName, y.StudentName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode(Student obj)
            {
                return obj.GetHashCode();
            }
        }

        static List<Student> GetDummyStudents()
        {
            return new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };
        }

        class Student
        {
            public int StudentID { get; set; }
            public String StudentName { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{StudentID} {StudentName} {Age}";
            }
        }
    }
}